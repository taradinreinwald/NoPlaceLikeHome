using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class YouFinshed : MonoBehaviour
{
    public TMP_Text finishText; // Reference to the text component to display a message
    public GameObject finishScreenUI; // Reference to the UI panel for the finish screen
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        if (rb != null)

        {
            // Show the finish screen UI
            finishScreenUI.SetActive(true);
            // Display a message
            finishText.text = "Congratulations! You finished the level!";
            // Optionally, pause the game or stop player movement
            Time.timeScale = 0f;
        }
    }
    public void HomeButton()
    {
        // Load the main menu scene (change "MainMenu" to your actual scene name)
        SceneManager.LoadScene("MainMenu");
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

