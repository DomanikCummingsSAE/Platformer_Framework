using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DomanikCummings
{
    /// <summary>
    /// This class holds functionality for scene transition and reloading this scene to restart the game.
    /// </summary>
    public class SceneLoader : MonoBehaviour
    {
        // TODO Loader 1/4: Declare a string variable for the name of the scene we want to load, which is this scene. (Write in the scene's name in Unity's Inspector.)
        [SerializeField] private string chosenScene;

        private void LoadScene()
        {
            // TODO Loader 2/4: Call Unity's "SceneManager.LoadScene" method and pass in your scene name variable to its parametersówithin the parentheses ( ).
            SceneManager.LoadScene(chosenScene);

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // TODO Loader 3/4: Call your load scene method to load this same scene again (effectively restarting the game).
            LoadScene();

            // TODO Loader Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO Loader Bonus 1: Modify your load scene method so that you can write any string or int level and it will load that. (Hint: Adding parameters to it might help!)

            // TODO Loader Bonus 2: Add a reference to your second scene (or any scenes you want) so that a second (or more) level can be loaded!

        }
    }
}
