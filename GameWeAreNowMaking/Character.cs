using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeAreNowMaking
{
    class Character
    {
        private int intBaseDamage { get; set; }
        private int intMaxHealth { get; set; }
        private int intCurrentHealth { get; set; }
        private int intArmor { get; set; }
        private int intCritRate { get; set; }
        private int intEvasionRate { get; set; }
        // Creates the array used to store Skills
        private Skill[] arrSkills = new Skill[4];
        // Creates the lists used to store Buffs and Debuffs
        List<Buff> lisBuffs = new List<Buff>();
        List<Debuff> lisDebuffs = new List<Debuff>();

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
        
        /// <summary>
        /// Damages the character for the given amount
        /// </summary>
        /// <param name="intDamageAmount"></param>
        private void take_damage(int intDamageAmount)
        {
            // Decreases the character's current health by the damage amount
            intCurrentHealth -= intDamageAmount;
        }

    }
}
