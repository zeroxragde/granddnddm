using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Tools
{
    class SmbPitchShifter
    {
        private int sampleRate;

        public SmbPitchShifter(int sampleRate)
        {
            this.sampleRate = sampleRate;
        }

        public void PitchShift(float pitchFactor, int numSamples, float[] inBuffer, float[] outBuffer)
        {
            for (int i = 0; i < numSamples; i++)
            {
                outBuffer[i] = inBuffer[i] * pitchFactor;
            }
        }
    }
}
