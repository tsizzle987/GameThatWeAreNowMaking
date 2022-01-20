﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeAreNowMaking
{
    class Character
    {
        private int intBaseDamage;
        private int intMaxHealth;
        private int intCurrentHealth;
        private int intArmor;
        private int intCritRate;
        private int intEvasionRate;
        private Skill[] arrSkills = new Skill[4];


        public Character(int intGivenBaseDamage, int intGivenMaxHealth, int intGivenArmor, int intGivenCritRate, int intGivenEvasionRate)
        {
            intBaseDamage = intGivenBaseDamage;
            intMaxHealth = intGivenMaxHealth;
            intCurrentHealth = intMaxHealth;
            intArmor = intGivenArmor;
            intCritRate = intGivenCritRate;
            intEvasionRate = intGivenEvasionRate;
        }

        /// <summary>
        /// Heal the character for the given amount
        /// </summary>
        /// <param name="intHealAmount"></param>
        private void heal(int intHealAmount)
        {
            // Increases the character's current health by the heal amount
            intCurrentHealth += intHealAmount;
            
            // If the character's current health is above its max health...
            if (intCurrentHealth > intMaxHealth)
            {
                // ...set the current health equal to the max health
                intCurrentHealth = intMaxHealth;
            } 
        }


    }
}
