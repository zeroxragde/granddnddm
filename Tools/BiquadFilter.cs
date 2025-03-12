using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Tools
{
    public enum FilterType { LowPass, HighPass, BandPass }

    public class BiquadFilter
    {
        private FilterType type;
        private float A0, A1, A2, B1, B2;
        private float x1, x2, y1, y2;

        public BiquadFilter(FilterType type, float cutoff, float Q, float sampleRate)
        {
            this.type = type;
            CalculateCoefficients(cutoff, Q, sampleRate);
            x1 = x2 = y1 = y2 = 0;
        }

        private void CalculateCoefficients(float cutoff, float Q, float sampleRate)
        {
            float w0 = 2 * (float)Math.PI * cutoff / sampleRate;
            float cosw0 = (float)Math.Cos(w0);
            float sinw0 = (float)Math.Sin(w0);
            float alpha = sinw0 / (2 * Q);

            float b0 = 0, b1_temp = 0, b2_temp = 0, a0_temp = 0, a1_temp = 0, a2_temp = 0;

            switch (type)
            {
                case FilterType.LowPass:
                    b0 = (1 - cosw0) / 2;
                    b1_temp = 1 - cosw0;
                    b2_temp = (1 - cosw0) / 2;
                    a0_temp = 1 + alpha;
                    a1_temp = -2 * cosw0;
                    a2_temp = 1 - alpha;
                    break;
                case FilterType.HighPass:
                    b0 = (1 + cosw0) / 2;
                    b1_temp = -(1 + cosw0);
                    b2_temp = (1 + cosw0) / 2;
                    a0_temp = 1 + alpha;
                    a1_temp = -2 * cosw0;
                    a2_temp = 1 - alpha;
                    break;
                case FilterType.BandPass:
                    b0 = alpha;
                    b1_temp = 0;
                    b2_temp = -alpha;
                    a0_temp = 1 + alpha;
                    a1_temp = -2 * cosw0;
                    a2_temp = 1 - alpha;
                    break;
            }

            A0 = b0 / a0_temp;
            A1 = b1_temp / a0_temp;
            A2 = b2_temp / a0_temp;
            B1 = a1_temp / a0_temp;
            B2 = a2_temp / a0_temp;
        }

        public float ProcessSample(float x)
        {
            float y = A0 * x + A1 * x1 + A2 * x2 - B1 * y1 - B2 * y2;
            x2 = x1;
            x1 = x;
            y2 = y1;
            y1 = y;
            return y;
        }
    }

}
