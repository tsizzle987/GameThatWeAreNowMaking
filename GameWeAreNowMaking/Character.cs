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

        public Character(int intGivenBaseDamage, int intGivenMaxHealth, int intGivenArmor, int intGivenCritRate, int intGivenEvasionRate, List<Skill> lisGivenSkills)
        {
            this.intBaseDamage = intGivenBaseDamage;
            this.intMaxHealth = intGivenMaxHealth;
            this.intCurrentHealth = this.intMaxHealth;
            this.intArmor = intGivenArmor;
            this.intCritRate = intGivenCritRate;
            this.intEvasionRate = intGivenEvasionRate;

            for (int i = 0; i < lisGivenSkills.Count; i++)
            {
                this.arrSkills[i] = lisGivenSkills[i];
            }
        }

        /// <summary>
        /// Heal the character for the given amount
        /// </summary>
        /// <param name="intHealAmount"></param>
        private void heal(int intHealAmount)
        {
            // Increases the character's current health by the heal amount
            this.intCurrentHealth += intHealAmount;
            
            // If the character's current health is above its max health...
            if (this.intCurrentHealth > this.intMaxHealth)
            {
                // ...set the current health equal to the max health
                this.intCurrentHealth = this.intMaxHealth;
            } 
        }
        
        /// <summary>
        /// Damages the character for the given amount
        /// </summary>
        /// <param name="intDamageAmount"></param>
        private void take_damage(int intDamageAmount)
        {
            // Decreases the character's current health by the damage amount
            this.intCurrentHealth -= intDamageAmount;
        }

        /// <summary>
        /// Reduces all of the character's cooldowns
        /// </summary>
        private void reduce_cooldowns()
        {
           foreach (Skill skSkill in this.arrSkills)
           {
                skSkill.reduce_cooldown();
           }
        }

        /// <summary>
        /// Reduces the duration of the character's conditions, removing them if their duration is zero
        /// </summary>
        private void reduce_durations()
        {
            foreach (Condition coCondition in this.lisConditions)
            {
                coCondition.reduce_duration();

                if (coCondition.intDuration == 0)
                {
                    this.lisConditions.Remove(coCondition);
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
            for (int i = 0; i < this.arrSkills.Length; i++)
            {
                // If there is no skill in this index...
                if (this.arrSkills[i] == null)
                {
                    // Set the current skill equal to the given skill and break out of the loop
                    this.arrSkills[i] = skGivenSkill;
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
            for (int i = 0; i < this.arrSkills.Length; i++)
            {
                // If the current skill is the given one...
                if (this.arrSkills[i] == skGivenSkill)
                {
                    // Set the current skill to null and break out of the loop
                    this.arrSkills[i] = null;
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
            this.arrSkills[intSkillIndex] = null;
        }
    }
}
