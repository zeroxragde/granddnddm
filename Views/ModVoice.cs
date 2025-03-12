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
        private float pitch = 1.05f;  // El valor por defecto es 1.0 (sin cambio en el pitch)

        // Variables para el filtro de timbre
        private BiquadFilter timbreFilter;
        private float timbreShiftValue = 1000f;  // Frecuencia central inicial
        private float timbreStrength = 0.5f;     // Mezcla wet/dry

        // Instancia del modulador multibanda
        private MultibandModulator multibandModulator;

        // Declaración global en la clase ModVoice
        private VoiceProcessor voiceProcessor;



        public ModVoice()
        {
            InitializeComponent();
            pitchShifter = new SMBPitchShifterC(); // Instancia de la clase pitch shifter

            // Configuración del TrackBar
            ptbPitch.Minimum = 0;   // Mínimo valor (graves)
            ptbPitch.Maximum = 100;    // Máximo valor (agudos)
            ptbPitch.Value = 50;        // Valor inicial centrado (sin cambio de tono)
                                        // Configuración del TrackBar


            ptbPitch.LargeChange = 20; // El valor por cambio grande
            ptbPitch.SmallChange = 1;  // El valor por cambio pequeño
                                       // Inicializar el modulador multibanda con sample rate 44100 Hz
            multibandModulator = new MultibandModulator(44100);
            // Inicializar el VoiceProcessor
            voiceProcessor = new VoiceProcessor(44100);
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
            timbreFilter = new BiquadFilter(FilterType.BandPass, timbreShiftValue, 0.7f, 44100f);

        }
        public static float[] ConvertirByteArrayAFloats(byte[] arreglo)
        {
            // Verificamos que el tamaño del arreglo sea múltiplo de 4
            if (arreglo.Length % 4 != 0)
            {
                throw new ArgumentException("El tamaño del arreglo de bytes no es múltiplo de 4.");
            }

            int cantidadFloats = arreglo.Length / 4;
            float[] resultado = new float[cantidadFloats];

            for (int i = 0; i < cantidadFloats; i++)
            {
                // Calculamos el índice de inicio de cada bloque de 4 bytes
                int inicio = i * 4;
                resultado[i] = BitConverter.ToSingle(arreglo, inicio);
            }

            return resultado;
        }
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // 1) Recibimos el buffer en 16 bits
            byte[] buffer = e.Buffer;

            // 2) Convertimos a float[] en rango [-1, 1]
            float[] floatBuffer = new float[buffer.Length / 2];
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                short sample = BitConverter.ToInt16(buffer, i * 2);
                floatBuffer[i] = sample / 32768f;
            }

            // 3) PITCH SHIFT
            //    Aquí usas el pitch que configuraste en tu TrackBar.
            //    pitchShifter.PitchShift() trabaja directamente sobre el arreglo floatBuffer.
            pitchShifter.PitchShift(pitch, floatBuffer.Length, 44100f, floatBuffer);

            // 4) TIMBRE FILTER (BandPass, etc.)
            //    Lo aplicas a floatBuffer en un loop, o en un método utilitario
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                float original = floatBuffer[i];
                float filtered = timbreFilter.ProcessSample(original);

                // Ajuste de mezcla timbreStrength (0.0 = no filtro, 1.0 = todo filtrado)
                floatBuffer[i] = (1.0f - timbreStrength) * original
                                 + timbreStrength * filtered;
            }

            // 5) MULTIBAND MODULATOR
            //    Procesa tu buffer con la instancia "multibandModulator"
            //    Recuerda que `Process(float[] input, float[] output)` usa 2 arreglos.
            //    Aquí podemos usar un buffer temporal si la librería lo requiere:
            float[] multiBandOutput = new float[floatBuffer.Length];
            multibandModulator.Process(floatBuffer, multiBandOutput);

            // Ahora multiBandOutput contiene el resultado del modulador.
            // Si lo deseas, puedes “encadenar” más efectos aquí mismo,
            // siempre dentro del dominio float, antes de pasarlo al VoiceProcessor.

            // 6) VOICE PROCESSOR
            //    Asumiendo que tu VoiceProcessor necesita float[] en rango [-1..1].
            float[] processedBuffer = voiceProcessor.ProcessBuffer(multiBandOutput);

            // 7) (OPCIONAL) CHORUS / DELAY / LO QUE SEA
            //    Si tu chorus está dentro del voiceProcessor u otra clase, aquí o arriba,
            //    pero siempre en float[].

            // 8) Finalmente, conviertes el resultado a 16 bits para reproducir.
            byte[] finalBytes = new byte[processedBuffer.Length * 2];
            for (int i = 0; i < processedBuffer.Length; i++)
            {
                short sample = (short)(processedBuffer[i] * 32768);
                finalBytes[i * 2] = (byte)(sample & 0xFF);
                finalBytes[i * 2 + 1] = (byte)((sample >> 8) & 0xFF);
            }

            // 9) Agregas el resultado ya en 16 bits al BufferedWaveProvider
            bufferedWaveProvider.AddSamples(finalBytes, 0, finalBytes.Length);
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
            waveIn.StopRecording();
            waveOut.Stop();
            btnStart.Text = "Iniciar Grabación";  // Cambiar el texto del botón
            isRecording = false;  // Cambiar el estado de grabación
            Close();  // Cerrar la aplicación
        }

        private void tbLowModFreq_Scroll(object sender, ScrollEventArgs e)
        {
            // La profundidad se normaliza entre 0 y 1.
            double newDepth = tbLowModDepth.Value / 100.0;
            multibandModulator.LowModDepth = newDepth;
            //lblLowModDepth.Text = $"Low Mod Depth: {newDepth:F2}";
        }

        private void tbLowModDepth_Scroll(object sender, ScrollEventArgs e)
        {
            // Asumiendo que queremos que la frecuencia varíe de 0.1 Hz a 5 Hz.
            double newFreq = 0.1 + (tbLowModFreq.Value / 100.0) * (5.0 - 0.1);
            multibandModulator.LowModFreq = newFreq;
            // lblLowModFreq.Text = $"Low Mod Frequency: {newFreq:F2} Hz";
        }

        private void trackBarTimbreShift_Scroll(object sender, ScrollEventArgs e)
        {
            // Mapeamos el valor [0..100] a un rango de frecuencias, por ejemplo [200..2000 Hz]
            // Ajusta este mapeo a tu gusto:
            timbreShiftValue = 200f + (trackBarTimbreShift.Value / 100f) * 1800f;

            // Volvemos a crear (o recalcular) el filtro con la nueva frecuencia central
            timbreFilter = new BiquadFilter(FilterType.BandPass, timbreShiftValue, 0.7f, 44100f);

            //  lblTimbreShift.Text = $"Shift: {timbreShiftValue:F2} Hz";
        }

        private void trackBarTimbreStrength_Scroll(object sender, ScrollEventArgs e)
        {
            // Mapeamos el valor [0..100] a [0..1]
            timbreStrength = trackBarTimbreStrength.Value / 100f;
         //   lblTimbreStrength.Text = $"Strength: {timbreStrength:P0}";
        }
    }
}
