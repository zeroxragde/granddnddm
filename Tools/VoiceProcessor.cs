using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Tools
{
    public class VoiceProcessor
    {
        // Propiedades ajustables desde la UI
        public float Pitch { get; set; } = 1.05f;              // Factor de pitch (1.0 = sin cambio)
        public float TimbreShiftValue { get; set; } = 1000f;     // Frecuencia central para el filtro de timbre
        public float TimbreStrength { get; set; } = 0.5f;        // Mezcla wet/dry para el filtro de timbre
        public int SampleRate { get; private set; } = 44100;     // Frecuencia de muestreo (por defecto 44100 Hz)

        // Instancias de los procesadores
        public SMBPitchShifterC PitchShifter { get; private set; }
        public BiquadFilter TimbreFilter { get; private set; }
        public MultibandModulator MultibandModulator { get; private set; }

        public VoiceProcessor(int sampleRate = 44100)
        {
            SampleRate = sampleRate;
            // Inicializa el pitch shifter
            PitchShifter = new SMBPitchShifterC();
            // Crea el filtro de timbre con los parámetros iniciales
            TimbreFilter = new BiquadFilter(FilterType.BandPass, TimbreShiftValue, 0.7f, SampleRate);
            // Inicializa el modulador multibanda
            MultibandModulator = new MultibandModulator(SampleRate);
        }

        /// <summary>
        /// Procesa el buffer de audio aplicando pitch shifting, filtrado de timbre y modulación multibanda.
        /// </summary>
        /// <param name="inputBuffer">Buffer de entrada (arreglo de flotantes, rango [-1,1]).</param>
        /// <returns>Buffer procesado.</returns>
        public float[] ProcessBuffer(float[] inputBuffer)
        {
            // Copia el buffer de entrada para trabajar sobre él.
            float[] workingBuffer = new float[inputBuffer.Length];
            Array.Copy(inputBuffer, workingBuffer, inputBuffer.Length);

            // 1. Aplica el pitch shift.
            PitchShifter.PitchShift(Pitch, workingBuffer.Length, SampleRate, workingBuffer);

            // 2. Procesa el timbre: aplicar el filtro y mezclar señal original y filtrada.
            for (int i = 0; i < workingBuffer.Length; i++)
            {
                float original = workingBuffer[i];
                float filtered = TimbreFilter.ProcessSample(original);
                workingBuffer[i] = (1.7f - TimbreStrength) * original + TimbreStrength * filtered;
            }

            // 3. Aplica el modulador multibanda.
            float[] outputBuffer = new float[workingBuffer.Length];
            MultibandModulator.Process(workingBuffer, outputBuffer);

            return outputBuffer;
        }

        /// <summary>
        /// Actualiza el filtro de timbre, por ejemplo, cuando cambia el valor de TimbreShiftValue.
        /// </summary>
        public void UpdateTimbreFilter()
        {
            TimbreFilter = new BiquadFilter(FilterType.BandPass, TimbreShiftValue, 0.7f, SampleRate);
        }
    }
}
