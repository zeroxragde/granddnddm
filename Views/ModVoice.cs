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



            // Configuración del TrackBar
            trackBarTimbreShift.Minimum = 0;   // Mínimo valor (graves)
            trackBarTimbreShift.Maximum = 100;    // Máximo valor (agudos)
            trackBarTimbreShift.Value = 50;        // Valor inicial centrado (sin cambio de tono)
            // Configuración del TrackBar
            trackBarTimbreShift.LargeChange = 20; // El valor por cambio grande
            trackBarTimbreShift.SmallChange = 1;  // El valor por cambio pequeño


            // Configuración del TrackBar
            trackBarTimbreStrength.Minimum = 0;   // Mínimo valor (graves)
            trackBarTimbreStrength.Maximum = 100;    // Máximo valor (agudos)
            trackBarTimbreStrength.Value = 50;        // Valor inicial centrado (sin cambio de tono)
            // Configuración del TrackBar
            trackBarTimbreStrength.LargeChange = 20; // El valor por cambio grande
            trackBarTimbreStrength.SmallChange = 1;  // El valor por cambio pequeño


            trackBarGain.Minimum = 0;   // Mínimo valor (0.0 ganancia)
            trackBarGain.Maximum = 200;    // Máximo valor (2.0 ganancia)
            trackBarGain.Value = 100;        // Valor inicial centrado (1.0 ganancia)
            trackBarGain.LargeChange = 20;  // Cambio grande por el TrackBar
            trackBarGain.SmallChange = 1;  // Cambio pequeño por el TrackBar

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
            timbreFilter = new BiquadFilter(FilterType.BandPass, timbreShiftValue, 1.7f, 44100f);
            AjustarParametrosParaVozFemenina();
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
        /*   private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
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
           }*/


        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            byte[] buffer = e.Buffer;

            // Convertimos a float[] en rango [-1, 1]
            float[] floatBuffer = new float[buffer.Length / 2];
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                short sample = BitConverter.ToInt16(buffer, i * 2);
                floatBuffer[i] = sample / 32768f; // Conversión correcta a float
            }

            // 3) PITCH SHIFT: Para hacer la voz más femenina, aumentamos el pitch ligeramente.
            pitch = (ptbPitch.Value / 100.0f) + 0.8f;  // Aumentar el pitch para una voz femenina (entre 1.0 y 1.3)
            pitchShifter.PitchShift(pitch, floatBuffer.Length, 44100f, floatBuffer);

            // 4) TIMBRE FILTER (BandPass, etc.): Ajustamos el timbre para hacerlo más suave y menos grave.
            // Aquí puedes experimentar con la frecuencia central para simular una voz femenina más clara.
            for (int i = 0; i < floatBuffer.Length; i++)
            {
                float original = floatBuffer[i];
                float filtered = timbreFilter.ProcessSample(original);

                // Ajuste de mezcla timbreStrength (0.0 = no filtro, 1.0 = todo filtrado)
                timbreStrength = trackBarTimbreStrength.Value / 100f;  // Control de timbre
                floatBuffer[i] = (1.0f - timbreStrength) * original + timbreStrength * filtered;
            }

            // 5) MULTIBAND MODULATOR (si es necesario, también puedes usarlo para dar más claridad)
            float[] multiBandOutput = new float[floatBuffer.Length];
            multibandModulator.Process(floatBuffer, multiBandOutput);

            // 6) VOICE PROCESSOR: Procesamos la voz (también puedes agregar efectos como reverb o delay aquí)
            float[] processedBuffer = voiceProcessor.ProcessBuffer(multiBandOutput);

            // 7) FILTRO DE GANANCIA
            float gain = trackBarGain.Value / 100f; // El valor del TrackBar de ganancia (0.0 a 2.0)
            for (int i = 0; i < processedBuffer.Length; i++)
            {
                processedBuffer[i] *= gain; // Multiplicamos cada muestra por la ganancia
            }

            // 8) Convertimos el resultado a 16 bits para reproducir
            byte[] finalBytes = new byte[processedBuffer.Length * 2];
            for (int i = 0; i < processedBuffer.Length; i++)
            {
                short sample = (short)(processedBuffer[i] * 32768);
                finalBytes[i * 2] = (byte)(sample & 0xFF);
                finalBytes[i * 2 + 1] = (byte)((sample >> 8) & 0xFF);
            }

            // 9) Agregamos el resultado ya en 16 bits al BufferedWaveProvider
            bufferedWaveProvider.AddSamples(finalBytes, 0, finalBytes.Length);
        }

     

        private void AjustarParametrosParaVozFemenina()
        {
            // Ajuste de Pitch: Para una voz femenina, el pitch debe ser ligeramente más alto.
            // Mantén el pitch en un valor más moderado para que no suene demasiado agudo.
            ptbPitch.Value = 60;  // Un valor moderado para un pitch más natural (aproximadamente 1.2)
            lblPitchValue.Text = $"{(ptbPitch.Value / 100.0f) + 0.5f:F2}";  // Actualizamos el label con el pitch

            // Ajuste de Timbre Shift: Ajustamos la frecuencia central para que esté en un rango medio.
            // Para una voz femenina, la frecuencia central debe estar en un rango de 1000 a 1800 Hz.
            trackBarTimbreShift.Value = 60;  // Establecemos la frecuencia central alrededor de 1300 Hz
            lblTimbreShift.Text = $"{200f + (trackBarTimbreShift.Value / 100f) * 1800f:F2} Hz";  // Actualizamos el label con la frecuencia

            // Ajuste de Timbre Strength: Ajustamos la mezcla del filtro para no hacerlo demasiado fuerte ni demasiado débil.
            // Un valor más moderado (alrededor de 0.6) mantendrá un buen balance entre la claridad y el carácter natural de la voz.
            trackBarTimbreStrength.Value = 60;  // Un valor moderado para la mezcla del filtro
            lblTimbreStrength.Text = $"{(trackBarTimbreStrength.Value / 100f):P0}";  // Actualizamos el label con la mezcla
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
            lblPitchValue.Text = $"{pitch:F2}";
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
            lblLowModDepth.Text = $"{newDepth:F2}";
        }

        private void tbLowModDepth_Scroll(object sender, ScrollEventArgs e)
        {
            // Asumiendo que queremos que la frecuencia varíe de 0.1 Hz a 5 Hz.
            double newFreq = 0.1 + (tbLowModFreq.Value / 100.0) * (5.0 - 0.1);
            multibandModulator.LowModFreq = newFreq;
            lblLowModFreq.Text = $"{newFreq:F2} Hz";
        }

        private void trackBarTimbreShift_Scroll(object sender, ScrollEventArgs e)
        {
            // Mapeamos el valor [0..100] a un rango de frecuencias, por ejemplo [200..2000 Hz]
            // Ajusta este mapeo a tu gusto:
            timbreShiftValue = 200f + (trackBarTimbreShift.Value / 100f) * 1800f;

            // Volvemos a crear (o recalcular) el filtro con la nueva frecuencia central
            timbreFilter = new BiquadFilter(FilterType.HighPass, timbreShiftValue, 0.7f, 44100f);

            lblTimbreShift.Text = $"{timbreShiftValue:F2} Hz";
        }

        private void trackBarTimbreStrength_Scroll(object sender, ScrollEventArgs e)
        {
            // Mapeamos el valor [0..100] a [0..1]
            timbreStrength = trackBarTimbreStrength.Value / 100f;
            lblTimbreStrength.Text = $"{timbreStrength:P0}";
        }

        private void trackBarGain_Scroll(object sender, ScrollEventArgs e)
        {
            // Obtenemos el valor del TrackBar de ganancia (rango entre 0 y 200)
            float gain = trackBarGain.Value / 100f; // Convertimos el valor a un rango entre 0.0 y 2.0

            // Actualizamos el label de ganancia para mostrar el valor actual
            lblGainValue.Text = $"{gain:F2}";
        }
    }
}
