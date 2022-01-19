using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeAreNowMaking
{
    class Skill
    {
        private string strName;
        private int intCooldown;
        private int intCurrentCooldown;
        private bool bolOffCooldown;

        public Skill(string strGivenName, int intGivenCooldown)
        {
            strName = strGivenName;
            intCooldown = intGivenCooldown;
            intCurrentCooldown = 0;
            bolOffCooldown = true;
        }

        public void reduce_cooldown()
        {
            if (intCurrentCooldown > 0)
            {
                intCurrentCooldown--;
            }

            if (intCurrentCooldown == 0)
            {
                bolOffCooldown = true;
            }
        }
    }
}
