using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeAreNowMaking
{
    class Skill
    {
        private string strName { get; set; }
        private int intCooldown { get; set; }
        private int intCurrentCooldown { get; set; }
        private bool bolOffCooldown { get; set; }

        public Skill(string strGivenName, int intGivenCooldown)
        {
            strName = strGivenName;
            intCooldown = intGivenCooldown;
            intCurrentCooldown = 0;
            bolOffCooldown = true;
        }

        /// <summary>
        /// Reduces the cooldown of the skill by 1
        /// </summary>
        public void reduce_cooldown()
        {
            // If the current cooldown is above zero...
            if (intCurrentCooldown > 0)
            {
                // ...reduce its value by 1
                intCurrentCooldown--;
            }

            // If the current cooldown is now equal to zero...
            if (intCurrentCooldown == 0)
            {
                // ...set the off cooldown boolean to true
                bolOffCooldown = true;
            }
        }
    }
}
