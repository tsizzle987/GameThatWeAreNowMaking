using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeAreNowMaking
{
    class Player : Character
    {
        private string strClass { get; set; }
        private int intCurrentExp { get; set; }

        public Player(string strGivenClass, int intGivenBaseDamage, int intGivenMaxHealth, int intGivenArmor, int intGivenCritRate, int intGivenEvasionRate) : base(intGivenBaseDamage, intGivenMaxHealth, intGivenArmor, intGivenCritRate, intGivenEvasionRate)
        {
            strClass = strGivenClass;
            intCurrentExp = 0;
        }


    }
}
