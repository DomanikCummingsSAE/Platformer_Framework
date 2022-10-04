using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DomanikCummings
{
    /// <summary>
    /// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining XP and detecting when we should level up.
    /// </summary>
    public class LevellingSystem : MonoBehaviour
    {
        // Lines 13-15 these declare the variables used later in the script
        private int currentXP;
        private int currentLvl;
        private float requiredXP;

        private void Start()
        {
            // Lines 20-22 declare the starting values for the variables used in the script
            currentLvl = 0;
            currentXP = 0;
            requiredXP = currentLvl * 100;

            // Displays to the console the current values of these variables
            Debug.Log("Current XP is: " + currentXP);
            Debug.Log("Current Level is: " + currentLvl);
            Debug.Log("Required XP is: " + requiredXP);

            // Increases the currentXP variable but a random amount between 50 and 100, than displays the new value to the console
            currentXP += Random.Range(50, 100);
            Debug.Log("Current XP is: " + currentXP);

            // Checks if the currentXP has reached the requriedXP to level up
            if (currentXP > requiredXP)
            {
                // if the currentXP has reached the requriedXP, than Lines 37-41 increase the currentLvl by 1, recalculate the new requriedXP as well as desplays the new values to the console
                currentLvl += 1;
                requiredXP = currentLvl * 100;
                Debug.Log("Current XP is: " + currentXP);
                Debug.Log("Current Level is: " + currentLvl);
                Debug.Log("Required XP is: " + requiredXP);
            }

            // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        }
    }
}
