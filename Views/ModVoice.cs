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
            soundTouchProcessor = new SoundTouch(); // Inicializar SoundTouch aquí
            soundTouchProcessor.PitchSemiTones = 5;  // Configurar SoundTouch
            soundTouchProcessor.Tempo = 1.0f;

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
                    WaveFormat = new WaveFormat(44100, 16,1), // 44.1 kHz, Mono
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

                    byte[] byteBuffer = ProcessAudio(ConvertToByteBuffer(outBuffer));//ConvertToByteBuffer(outBuffer);

                    byte[] byteBuffer2 = ConvertToByteBuffer(outBuffer);
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
        private byte[] ProcessAudio(byte[] buffer)
        {
            int numSamples = buffer.Length / 2;  // 2 bytes por muestra (16 bits)
            float[] floatBuffer = new float[numSamples];

            // Convertir los datos de 16-bit a 32-bit flotante
            for (int i = 0; i < numSamples; i++)
            {
                short sample = BitConverter.ToInt16(buffer, i * 2);  // Convertir 2 bytes a 16 bits
                floatBuffer[i] = sample / 32768f;  // Convertir a float en el rango [-1, 1]
            }

            // Inicializar SoundTouchProcessor
            SoundTouch soundTouchProcessor = new SoundTouch();
            soundTouchProcessor.PitchSemiTones = 5;  // Cambiar el tono en 5 semitonos
            soundTouchProcessor.Tempo = 1.0f;    // Mantener la misma velocidad (1.0f para mantener)

            float[] outputBuffer = new float[numSamples];

            // Enviar todas las muestras a SoundTouch de una sola vez
            soundTouchProcessor.PutSamples(floatBuffer, (uint)numSamples);
            soundTouchProcessor.Flush();  // Asegúrate de que las muestras sean procesadas

            // Recibir las muestras procesadas
            int numProcessed = (int)soundTouchProcessor.ReceiveSamples(outputBuffer, (uint)outputBuffer.Length);
            Console.WriteLine($"Número de muestras procesadas: {numProcessed}");

            if (numProcessed == 0)
            {
                Console.WriteLine("No se procesaron muestras.");
                return new byte[0];
            }

            // Convertir las muestras procesadas de float[] a byte[]
            byte[] byteOutput = new byte[numProcessed * 2]; // 2 bytes por muestra (16 bits)
            for (int j = 0; j < numProcessed; j++)
            {
                short sample = (short)(outputBuffer[j] * 32768);  // Convertir a 16-bit
                byteOutput[j * 2] = (byte)(sample & 0xff);      // Parte baja
                byteOutput[j * 2 + 1] = (byte)((sample >> 8) & 0xff);  // Parte alta
            }

            // Devolver el audio procesado
            return byteOutput;


        }



        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
