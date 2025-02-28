using GranDnDDM.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GranDnDDM.Views
{
    public partial class MusicControl : Form
    {
        private System.Windows.Forms.Timer checkSongTimer;
        private WindowsMediaPlayer player;
        private bool isPlaying = false;
        private System.Windows.Forms.Timer trackTimer;
        private bool isLooping = false;
        private bool isUserDragging = false;
        private SoundControl soundControl = new SoundControl();
        public MusicControl()
        {
            InitializeComponent();
            // Configuramos un Timer
            checkSongTimer = new System.Windows.Forms.Timer();
            checkSongTimer.Interval = 1000; // cada segundo (ajusta a tu gusto)
            checkSongTimer.Tick += CheckSongTimer_Tick;
            checkSongTimer.Start();
            player = new WindowsMediaPlayer();
            player.settings.volume = 40; // volumen inicial
            trackBarVolume.Value = 40;       // valor inicial

            // Crea el timer para actualizar el trackbar
            trackTimer = new System.Windows.Forms.Timer();
            trackTimer.Interval = 1000;  // medio segundo, por ejemplo
            trackTimer.Tick += TrackTimer_Tick;


            // Opcional: iniciar labels
            lblRestante.Text = "00:00";
            lblFulltime.Text = "00:00";
        }
        private void TrackTimer_Tick(object sender, EventArgs e)
        {
            // Verificamos si el player está reproduciendo algo
            if (player != null && player.currentMedia != null && player.playState == WMPPlayState.wmppsPlaying)
            {
                // Duración total (en segundos)
                double dur = player.currentMedia.duration;
                // Posición actual (en segundos)
                double pos = player.controls.currentPosition;

                // Ajusta el máximo del trackBar según la duración
                trackBarProgreso.Maximum = (int)dur;

                // Si la posición no excede el max
                if (pos <= dur)
                {
                    trackBarProgreso.Value = (int)pos;
                }

                // Actualiza labels: WMP provee .durationString y .currentPositionString (formato mm:ss)
                lblFulltime.Text = player.currentMedia.durationString;
                lblRestante.Text = player.controls.currentPositionString;
            }
            else if (player.playState == WMPPlayState.wmppsStopped)
            {
                // Si la canción terminó, reseteamos
                trackTimer.Stop();
                trackBarProgreso.Value = 0;
                lblRestante.Text = "00:00";
                btnPlay.ImageIndex = 0;
                // Si quieres mantener la dur total:
                // lblFulltime.Text = "00:00";
            }
        }
        private void CheckSongTimer_Tick(object sender, EventArgs e)
        {
            if (GlobalTools.MusicaActual != null)
            {
                lblMusic.Text = GlobalTools.MusicaActual.RealName;
            }
            else
            {
                lblMusic.Text = "Sin canción seleccionada";
            }
        }
        private void btnOpenList_Click(object sender, EventArgs e)
        {
            ListSongs listSongs = new ListSongs();
            listSongs.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (GlobalTools.MusicaActual == null)
            {
                MessageBox.Show("No hay canción seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isPlaying)
            {
                // 1) Reproducir
                string filePath = Path.Combine(Application.StartupPath, "Musica", GlobalTools.MusicaActual.FileName);
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("El archivo de la canción no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Configuramos la URL del reproductor y reproducimos
                player.URL = filePath;
                player.controls.play();

                // 2) Actualizamos el estado
                isPlaying = true;
                // Supongamos que en tu imageList1 la posición 3 es el ícono de "Pause"
                btnPlay.ImageIndex = 3;

                // (Opcional) Iniciar el Timer que controla el trackBar de progreso
                trackTimer?.Start();
            }
            else
            {
                // 1) Pausar
                player.controls.pause();

                // 2) Actualizamos el estado
                isPlaying = false;
                // Supongamos que en tu imageList1 la posición 0 es el ícono de "Play"
                btnPlay.ImageIndex = 0;

                // (Opcional) Pausar el Timer
                trackTimer?.Stop();
            }
        }

        private void trackBarVolume_ValueChanged()
        {
            player.settings.volume = trackBarVolume.Value;
            // (opcional) Mostrar el valor en un label
            lblVolumeValue.Text = trackBarVolume.Value.ToString();
        }

        private void trackBarProgreso_ValueChanged()
        {
            // Si el player está reproduciendo algo
            if (isUserDragging && player != null && player.currentMedia != null)
            {
                player.controls.currentPosition = trackBarProgreso.Value;
            }
        }

        private void trackBarProgreso_MouseDown(object sender, MouseEventArgs e)
        {
            isUserDragging = true;
        }

        private void trackBarProgreso_MouseUp(object sender, MouseEventArgs e)
        {
            isUserDragging = false;
            if (player != null && player.currentMedia != null)
            {
                player.controls.currentPosition = trackBarProgreso.Value;
            }
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            player.settings.mute = !player.settings.mute;
            if (btnMute.ImageIndex == 6)
            {
                btnMute.ImageIndex = 1;
            }
            else
            {
                btnMute.ImageIndex = 6;
            }

        }

        private void btnOpenSounds_Click(object sender, EventArgs e)
        {
           
            soundControl.Show();
        }

        private void btnLoopToggle_Click(object sender, EventArgs e)
        {
            // Toggle la variable isLooping
            isLooping = !isLooping;

            // Ajustar el modo loop en Windows Media Player
            player.settings.setMode("loop", isLooping);

            // Opcional: Cambiar el ícono o texto del botón según el estado
            if (isLooping)
            {
                btnLoopToggle.ImageIndex = 9;
                // Si tienes un ImageList, puedes hacer btnLoop.ImageIndex = X;
            }
            else
            {
                btnLoopToggle.ImageIndex = 8;
                // btnLoop.ImageIndex = Y;
            }
        }
    }
}
