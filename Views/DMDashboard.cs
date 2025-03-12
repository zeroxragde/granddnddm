using GranDnDDM.Tools;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GranDnDDM.Views
{
    public partial class DMDashboard : Form
    {
        private Form1 principal;
        private MusicControl music = new MusicControl();
        private EditorMap empa = new EditorMap();
        private CreatureList cl = new CreatureList();
        private ShopCreeator sh = new ShopCreeator();
        private ModVoice modVoice = new ModVoice();
        /// <summary>
        /// wave micro
        /// </summary>
        private WaveInEvent waveIn;
        private WaveOutEvent waveOut;
        private BufferedWaveProvider bufferedWaveProvider;
        private bool isListening = false;
        private SmbPitchShifter pitchShifter;
        private float pitchFactor = 1.0f;

        public DMDashboard(Form1 f)
        {
            InitializeComponent();
            principal = f;

            trackPitch.Minimum = -12;
            trackPitch.Maximum = 12;
            trackPitch.Value = 0;
            trackPitch.TickFrequency = 1;
        }

        private void DMDashboard_Load(object sender, EventArgs e)
        {
            myForm.Text = "Tablero de " + GlobalTools.DM;
            // Configura el inicio en posición manual
            StartPosition = FormStartPosition.Manual;
            TopMost = true;

            // Obtiene el área de trabajo de la pantalla principal
            Rectangle screenArea = Screen.PrimaryScreen.WorkingArea;

            // Calcula la posición X centrada
            int centerX = screenArea.Left + (screenArea.Width - Width) / 2;

            // Establece la ubicación en el centro arriba
            Location = new Point(centerX, screenArea.Top);

        }

        private void DMDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Close();
        }

        private void btnMapEditor_Click(object sender, EventArgs e)
        {
            if (empa.IsDisposed)
            {
                empa = new EditorMap();
            }
            empa.Show();
        }

        private void btnMusicControl_Click(object sender, EventArgs e)
        {
            if (music.IsDisposed)
            {
                music = new MusicControl();
            }
            music.Show();
        }

        private void btnCreatures_Click(object sender, EventArgs e)
        {
            if (cl.IsDisposed)
            {
                cl = new CreatureList();
            }
            cl.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpenShop_Click(object sender, EventArgs e)
        {
            if (sh.IsDisposed)
            {
                sh = new ShopCreeator();
            }
            sh.Show();
        }

        private void btnMicroToggle_Click(object sender, EventArgs e)
        {

            if (isListening)
            {
                StopMicrophone();
            }
            else
            {
                StartMicrophone();
            }

            isListening = !isListening;
            btnMicroToggle.ImageIndex = btnMicroToggle.ImageIndex == 6 ? 5 : 6;
            //btnToggleMic.Text = isMuted ? "Activar Micrófono" : "Silenciar Micrófono";

        }
        private void StartMicrophone()
        {
            try
            {
                waveIn = new WaveInEvent
                {
                    WaveFormat = new WaveFormat(44100, 1) // 44.1 kHz, Mono
                };

                bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);
                bufferedWaveProvider.DiscardOnBufferOverflow = true;

                pitchShifter = new SmbPitchShifter(waveIn.WaveFormat.SampleRate);

                waveIn.DataAvailable += (s, a) =>
                {
                    float[] floatBuffer = ConvertToFloatBuffer(a.Buffer, a.BytesRecorded);
                    float[] outBuffer = new float[floatBuffer.Length];

                    // Aplicar cambio de tono
                    pitchShifter.PitchShift(pitchFactor, floatBuffer.Length, floatBuffer, outBuffer);

                    byte[] byteBuffer = ConvertToByteBuffer(outBuffer);
                    bufferedWaveProvider.AddSamples(byteBuffer, 0, byteBuffer.Length);
                };

                waveOut = new WaveOutEvent();
                waveOut.Init(bufferedWaveProvider);
                waveOut.Play();

                waveIn.StartRecording();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar el micrófono: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopMicrophone()
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
            }

            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }

        private void trackPitch_Scroll(object sender, EventArgs e)
        {
            // pitchFactor = (float)Math.Pow(2, trackPitch.Value / 12.0);
        }
        private float[] ConvertToFloatBuffer(byte[] byteBuffer, int bytesRecorded)
        {
            float[] floatBuffer = new float[bytesRecorded / 2];
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                floatBuffer[i] = BitConverter.ToInt16(byteBuffer, i * 2) / 32768f;
            }
            return floatBuffer;
        }

        private byte[] ConvertToByteBuffer(float[] floatBuffer)
        {
            byte[] byteBuffer = new byte[floatBuffer.Length * 2];
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                short intSample = (short)(floatBuffer[i] * 32767);
                BitConverter.GetBytes(intSample).CopyTo(byteBuffer, i * 2);
            }
            return byteBuffer;
        }

        private void btnModVoice_Click(object sender, EventArgs e)
        {
            if (modVoice.IsDisposed)
            {
                modVoice = new ModVoice();
            }
            
            modVoice.Show();
        }
    }
}
