using GranDnDDM.Tools;
using NAudio.Wave;
using SoundTouchSharp;
using System;
using System.Windows.Forms;

namespace GranDnDDM.Views
{
    public partial class ModVoice : Form
    {
        private WaveInEvent waveIn;
        private WaveOutEvent waveOut;
        private BufferedWaveProvider bufferedWaveProvider;
        private SoundTouch soundTouchProcessor;  // Instancia de SoundTouchSharp
        private bool isListening = false;
        private SmbPitchShifter pitchShifter;
        private float pitchFactor = 1.0f;

        public ModVoice()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
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
        }
        private void StartMicrophone()
        {
            try
            {
                soundTouchProcessor = new SoundTouch(); // 44.1 kHz, Mono

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

                    byte[] byteBuffer = WaveIn_DataAvailable(ConvertToByteBuffer(outBuffer));//ConvertToByteBuffer(outBuffer);
                        bufferedWaveProvider.AddSamples(byteBuffer, 0, byteBuffer.Length);
                   // WaveIn_DataAvailable(s, a);
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

        private void ModVoice_Load(object sender, EventArgs e)
        {

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
        private byte[] WaveIn_DataAvailable(byte[] buffer)
        {
            //byte[] buffer = e.Buffer;

            // Crear una muestra flotante de los datos de audio capturados
            float[] floatBuffer = new float[buffer.Length / 2];
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                short sample = BitConverter.ToInt16(buffer, i * 2);  // Convertir bytes a 16 bits
                floatBuffer[i] = sample / 32768f; // Convertir a punto flotante en el rango [-1, 1]
            }

            // Aplicar pitch shifting y time stretching usando SoundTouchSharp
            soundTouchProcessor.PutSamples(floatBuffer, (uint)floatBuffer.Length); // Procesar el audio
            float[] outputBuffer = new float[floatBuffer.Length];  // Buffer de salida
            uint u = Convert.ToUInt32(outputBuffer.Length);
            int numSamples = (int)soundTouchProcessor.ReceiveSamples(outputBuffer, u);  // Obtener muestras procesadas

            // Convertir de vuelta a bytes para reproducción
            byte[] byteOutput = new byte[numSamples * 2]; // Dos bytes por muestra
            for (int i = 0; i < numSamples; i++)
            {
                short sample = (short)(outputBuffer[i] * 32768); // Convertir a 16-bit
                byteOutput[i * 2] = (byte)(sample & 0xff);      // Parte baja
                byteOutput[i * 2 + 1] = (byte)((sample >> 8) & 0xff);  // Parte alta
            }

            // Agregar el audio procesado al BufferedWaveProvider para que se pueda reproducir
            // bufferedWaveProvider.AddSamples(byteOutput, 0, byteOutput.Length);
            return byteOutput;
        }



        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
