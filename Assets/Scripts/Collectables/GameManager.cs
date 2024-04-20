using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance
    public int score = 0; // Player's score
    public TMP_Text scoreText; // Reference to the UI text component to display the score


    private void Awake()
    {
        // Singleton pattern to ensure only one instance of the GameManager exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Method to increase the player's score
    public void IncreaseScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }
    // Method to update the UI with the current score
    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "FOOD: " + score.ToString();
        }
    }
}
