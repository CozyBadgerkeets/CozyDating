using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    /// <summary>
    /// Allows the player to start the game
    /// as of writting this no way to save so just starts at scene 1
    /// </summary>
    public void Play()
    {
        // Loads the previous scene
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void loadSettings()
    {
        // Play Animation that lets you change settings
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        // \/ Line only works when game is built
        // Application.Quit();
    }
}
