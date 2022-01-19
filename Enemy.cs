using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeAreNowMaking
{
    class Enemy
    {
        private string strName;
        private int intMaxHealth;
        private int intCurrentHealth;
        private int intArmor;
        private int intExp;
        private int intBaseDamage;
        private int intCritRate;
        private int intEvasionRate;
        private Skill[] arrSkills = new Skill[4];

        public Enemy(string strGivenName, int intGivenMaxHealth, int intGivenArmor, int intGivenExp, int intGivenBaseDamage, int intGivenCritRate, int intGivenEvasionRate)
        {
            strName = strGivenName;
            intMaxHealth = intGivenMaxHealth;
            intCurrentHealth = intMaxHealth;
            intArmor = intGivenArmor;
            intExp = intGivenExp;
            intBaseDamage = intGivenBaseDamage;
            intCritRate = intGivenCritRate;
            intEvasionRate = intGivenEvasionRate;
        }
    }
}
