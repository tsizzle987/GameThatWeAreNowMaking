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
        private List<Skill> lisInitialSkills;

        public Player(string strGivenClass, int intGivenBaseDamage, int intGivenMaxHealth, int intGivenArmor, int intGivenCritRate, int intGivenEvasionRate, List<Skill> lisGivenSkills) : base(intGivenBaseDamage, intGivenMaxHealth, intGivenArmor, intGivenCritRate, intGivenEvasionRate, lisGivenSkills)
        {
            this.strClass = strGivenClass;
            this.intCurrentExp = 0;
        }
    }
}
