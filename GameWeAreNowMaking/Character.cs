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
        // Creates the list used to store Conditions
        List<Condition> lisConditions = new List<Condition>();

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

        /// <summary>
        /// Reduces all of the character's cooldowns
        /// </summary>
        private void reduce_cooldowns()
        {
           foreach (Skill skSkill in arrSkills)
           {
                skSkill.reduce_cooldown();
           }
        }

        /// <summary>
        /// Reduces the duration of the character's conditions, removing them if their duration is zero
        /// </summary>
        private void reduce_durations()
        {
            foreach (Condition coCondition in lisConditions)
            {
                coCondition.reduce_duration();

                if (coCondition.intDuration == 0)
                {
                    lisConditions.Remove(coCondition);
                }
            }
        }

        /// <summary>
        /// Adds the given skill to the skill array if there is an available index
        /// </summary>
        /// <param name="skGivenSkill"></param>
        private void add_skill(Skill skGivenSkill)
        {
            // For each index in the skill array...
            for (int i = 0; i < arrSkills.Length; i++)
            {
                // If there is no skill in this index...
                if (arrSkills[i] == null)
                {
                    // Set the current skill equal to the given skill and break out of the loop
                    arrSkills[i] = skGivenSkill;
                    break;
                }
            }
        }

        /// <summary>
        /// Removes the given skill from the skill array
        /// </summary>
        /// <param name="skGivenSkill"></param>
        private void remove_skill(Skill skGivenSkill)
        {
            // For each index in the skill array...
            for (int i = 0; i < arrSkills.Length; i++)
            {
                // If the current skill is the given one...
                if (arrSkills[i] == skGivenSkill)
                {
                    // Set the current skill to null and break out of the loop
                    arrSkills[i] = null;
                    break;
                }

            }
        }

        /// <summary>
        /// Removes the skill at the given index from the skill array
        /// </summary>
        /// <param name="intSkillIndex"></param>
        private void remove_skill(int intSkillIndex)
        {
            arrSkills[intSkillIndex] = null;
        }
    }
}
