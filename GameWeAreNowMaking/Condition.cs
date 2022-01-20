using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeAreNowMaking
{
    class Condition
    {
        private string strName { get; set; }
        private int intDuration { get; set; }

        public Condition(string strGivenName, int intGivenDuration)
        {
            strName = strGivenName;
            intDuration = intGivenDuration;
        }

        /// <summary>
        /// Reduces the duration of the condition by 1
        /// </summary>
        private void reduce_duration()
        {
            // If the current duration is greater than zero...
            if (intDuration > 0)
            {
                // ...reduce it by 1
                intDuration--;
            }
        }
    }
}
