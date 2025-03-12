using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Tools
{
    public class MultibandModulator
    {
        private BiquadFilter lowFilter;
        private BiquadFilter bandFilter;
        private BiquadFilter highFilter;
        private double sampleRate;

        // Parámetros de modulación para cada banda
        public double LowModFreq { get; set; } = 0.5;   // Hz
        public double BandModFreq { get; set; } = 0.7;  // Hz
        public double HighModFreq { get; set; } = 0.9;  // Hz
        public double LowModDepth { get; set; } = 0.5;  // Profundidad (0 a 1)
        public double BandModDepth { get; set; } = 0.5;
        public double HighModDepth { get; set; } = 0.5;

        public MultibandModulator(double sampleRate)
        {
            this.sampleRate = sampleRate;
            // Definir frecuencias de corte para separar las bandas
            float lowCutoff = 300f;   // Banda baja: por debajo de 300 Hz
            float highCutoff = 3000f; // Banda alta: por encima de 3000 Hz
            float Q = 0.707f;         // Factor Q para un filtro Butterworth

            // Filtros para cada banda
            lowFilter = new BiquadFilter(FilterType.LowPass, lowCutoff, Q, (float)sampleRate);
            highFilter = new BiquadFilter(FilterType.HighPass, highCutoff, Q, (float)sampleRate);
            // Para la banda media usamos un filtro pasa banda centrado entre lowCutoff y highCutoff
            float midCenter = (lowCutoff + highCutoff) / 2;
            bandFilter = new BiquadFilter(FilterType.BandPass, midCenter, Q, (float)sampleRate);
        }

        // Procesa el arreglo de entrada y escribe la señal modulada en "output"
        public void Process(float[] input, float[] output)
        {
            int numSamples = input.Length;
            for (int i = 0; i < numSamples; i++)
            {
                float sample = input[i];

                // Separar la señal en bandas
                float lowBand = lowFilter.ProcessSample(sample);
                float highBand = highFilter.ProcessSample(sample);
                float midBand = bandFilter.ProcessSample(sample);

                // Calcular modulación LFO para cada banda: factor = 1 + depth * sin(2π * freq * t)
                double t = i / sampleRate;
                double lowLFO = 1.0 + LowModDepth * Math.Sin(2 * Math.PI * LowModFreq * t);
                double midLFO = 1.0 + BandModDepth * Math.Sin(2 * Math.PI * BandModFreq * t);
                double highLFO = 1.0 + HighModDepth * Math.Sin(2 * Math.PI * HighModFreq * t);

                lowBand = (float)(lowBand * lowLFO);
                midBand = (float)(midBand * midLFO);
                highBand = (float)(highBand * highLFO);

                // Recomponer la señal sumando las tres bandas
                output[i] = lowBand + midBand + highBand;
            }
        }
    }
}
