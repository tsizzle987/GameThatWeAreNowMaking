using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeAreNowMaking
{
    class Enemy : Character
    {
        private string strName;
        private int intTier;
        private int intExpReward;

        public Enemy(string strGivenName, int intGivenTier, int intGivenExpReward, int intGivenBaseDamage, int intGivenMaxHealth, int intGivenArmor, int intGivenCritRate, int intGivenEvasionRate) : base(intGivenBaseDamage, intGivenMaxHealth, intGivenArmor, intGivenCritRate, intGivenEvasionRate)
        {
            strName = strGivenName;
            intTier = intGivenTier;
            intExpReward = intGivenExpReward;
        }
    }
}
