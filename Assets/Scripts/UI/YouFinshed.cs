using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TarodevController; 



public class YouFinshed : MonoBehaviour
{
    
    public GameObject finishScreenUI; // Reference to the UI panel for the finish screen

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding GameObject is the player
        if (other.gameObject.GetComponent<PlayerController>())
        {
            // Display the win screen UI
            finishScreenUI.SetActive(true);
            Time.timeScale = 0f; 
        }
    }
    public void HomeButton()
    {
        Time.timeScale = 1f;
        // Load the main menu scene (change "MainMenu" to your actual scene name)
        SceneManager.LoadScene("MainScreen");
        // Resume game time
        
    }
    public void RetryLevel()
    {
        Time.timeScale = 1f;
        // Reload the current scene to restart the level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // Resume game time
        
    }
    public void NextLevel()
    {
        Time.timeScale = 1f;
        // Load the main menu scene (change "MainMenu" to your actual scene name)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Resume game time

    }



}

