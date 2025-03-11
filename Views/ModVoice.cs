using GranDnDDM.Tools;
using NAudio.Wave;
using SoundTouch;
using System;
using System.Windows.Forms;

namespace GranDnDDM.Views
{
    public partial class ModVoice : Form
    {
        private WaveInEvent waveIn;
        private WaveOutEvent waveOut;
        private BufferedWaveProvider bufferedWaveProvider;
        private SMBPitchShifterC pitchShifter;
        private bool isRecording = false;
        // Variable de pitch que se ajustará con el TrackBar
        private float pitch = 1.0f;  // El valor por defecto es 1.0 (sin cambio en el pitch)

        private SoundTouch.SoundTouchProcessor soundTouchProcessor;

        public ModVoice()
        {
            InitializeComponent();
            pitchShifter = new SMBPitchShifterC(); // Instancia de la clase pitch shifter
            soundTouchProcessor = new SoundTouchProcessor();
            // Configuración del TrackBar
            ptbPitch.Minimum = 0;   // Mínimo valor (graves)
            ptbPitch.Maximum = 100;    // Máximo valor (agudos)
            ptbPitch.Value = 50;        // Valor inicial centrado (sin cambio de tono)
                                        // Configuración del TrackBar


            ptbPitch.LargeChange = 20; // El valor por cambio grande
            ptbPitch.SmallChange = 1;  // El valor por cambio pequeño

        }

        private void ModVoice_Load(object sender, EventArgs e)
        {
            // Configurar la captura de audio (micrófono)
            waveIn = new WaveInEvent();
            waveIn.WaveFormat = new WaveFormat(44100, 16, 1); // Formato de audio: 44100 Hz, 16 bits, mono
            waveIn.DataAvailable += WaveIn_DataAvailable;

            // Configurar la salida de audio
            waveOut = new WaveOutEvent();
            bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);
            waveOut.Init(bufferedWaveProvider);


        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            byte[] buffer = e.Buffer;

            // Crear una muestra flotante de los datos de audio capturados
            float[] floatBuffer = new float[buffer.Length / 2];
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                short sample = BitConverter.ToInt16(buffer, i * 2);  // Convertir bytes a 16 bits
                floatBuffer[i] = sample / 32768f; // Convertir a punto flotante en el rango [-1, 1]
            }

            // Procesar el audio con el pitch shifter
            float[] outputBuffer = new float[floatBuffer.Length];
            pitchShifter.PitchShift(pitch, floatBuffer.Length, 44100f, floatBuffer);  // Cambiar tono por 1.5 veces

            // El algoritmo puede basarse en la idea de retardo, modulación de frecuencia y mezcla de voces
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                // Aquí iría el procesamiento del chorus (ejemplo de delay y mezcla)
                // Esto es solo un esqueleto, se debería implementar la lógica específica de chorus
                floatBuffer[i] *= 1.7f; // Aplicar algo de "wet" mix para chorus (solo ejemplo)
            }
            Array.Copy(floatBuffer, outputBuffer, floatBuffer.Length); // Copiar el audio procesado a outputBuffer

            // Convertir el buffer procesado a bytes para reproducción
            byte[] byteOutput = new byte[outputBuffer.Length * 2]; // Dos bytes por muestra
            for (int i = 0; i < outputBuffer.Length; i++)
            {
                short sample = (short)(outputBuffer[i] * 32768); // Convertir a 16-bit
                byteOutput[i * 2] = (byte)(sample & 0xff);      // Parte baja
                byteOutput[i * 2 + 1] = (byte)((sample >> 8) & 0xff);  // Parte alta
            }

            // Agregar el audio procesado al BufferedWaveProvider para que se pueda reproducir
            bufferedWaveProvider.AddSamples(byteOutput, 0, byteOutput.Length);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Iniciar la captura y la reproducción (ya lo hicimos al cargar el formulario, pero si deseas un botón de control)
            if (isRecording)
            {
                // Detener la grabación y detener la reproducción
                waveIn.StopRecording();
                waveOut.Stop();
                btnStart.Text = "Iniciar Grabación";  // Cambiar el texto del botón
                isRecording = false;  // Cambiar el estado de grabación
            }
            else
            {
                // Iniciar la grabación y reproducción
                waveIn.StartRecording();
                waveOut.Play();
                btnStart.Text = "Detener Grabación";  // Cambiar el texto del botón
                isRecording = true;  // Cambiar el estado de grabación
            }
        }



        private void ptbPitch_Scroll(object sender, ScrollEventArgs e)
        {
            // El rango del TrackBar es 0 a 100, por lo que lo normalizamos entre 0.5 y 2.0 para el pitch
            pitch = (ptbPitch.Value / 100.0f) + 0.5f;  // Valor de pitch entre 0.5 y 2.0

            // Actualizar el label para mostrar el pitch actual
            lblPitchValue.Text = $"Pitch: {pitch:F2}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();  // Cerrar la aplicación
        }
    }
}
