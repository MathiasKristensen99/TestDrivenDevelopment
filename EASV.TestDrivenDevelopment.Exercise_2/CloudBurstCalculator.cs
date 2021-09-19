using System;

namespace EASV.TestDrivenDevelopment.Exercise_2
{
    public class CloudBurstCalculator : ICloudBurstCalculator
    {
        /*
        * First you should implement a function using TDD that can be used used to decide weather or not a cloudburst (dan: skybrud) is present.
        * The data representing rain is an array of doubles. Each entry representing the amount of rain in millimeters in 5 minutes.
        * Find the definition of cloudburst. Then implement a logical function:
         * The function must return -1 in case there are no cloudburst.
         * Otherwise it will return the first index of the first occurrence of a period with cloudburst.
        */
        
        public int ContainsCloudburst(double[] rain)
        {
            int res = 0;
            foreach (double d in rain)
            {
                if (d >= 5)
                {
                    res = (int) d;
                    return res;
                }
            }

            return -1;
        }
    }
}