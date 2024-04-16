using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TarodevController; 



public class YouFinshed : MonoBehaviour
{
    
    public GameObject finishScreenUI; // Reference to the UI panel for the finish screen

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding GameObject is the player
        if (other.gameObject.GetComponent<PlayerController>())
        {
            // Display the win screen UI
            finishScreenUI.SetActive(false);
        }
    }
    public void HomeButton()
    {
        // Load the main menu scene (change "MainMenu" to your actual scene name)
        SceneManager.LoadScene("MainScreen");
        // Resume game time
        Time.timeScale = 1f;
    }
    public void RetryLevel()
    {
        // Reload the current scene to restart the level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // Resume game time
        Time.timeScale = 1f;
    }
}

