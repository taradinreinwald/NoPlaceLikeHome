using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class Collectible_2 : MonoBehaviour

{
    public int scoreValue = 10; // Score value of each collectible
    private PlayerController playerController; // Reference to the PlayerController

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>(); // Find the PlayerController in the scene
    }

    private void Update()
    {
        // Check if the player presses the "C" key
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Check if the player is close enough to the collectible
            if (IsPlayerNearby())
            {
                Collect();
            }
        }
    }

    private bool IsPlayerNearby()
    {
        if (playerController != null)
        {
            // Get the position of the player
            Vector2 playerPosition = playerController.transform.position;

            // Get the position of the collectible
            Vector2 collectiblePosition = transform.position;

            // Calculate the distance between the player and the collectible
            float distance = Vector2.Distance(collectiblePosition, playerPosition);

            // Check if the distance is less than the specified threshold
            return distance < 1.5f; // Adjust this threshold as needed
        }
        else
        {
            Debug.LogError("PlayerController not found!");
            return false;
        }
    }

    private void Collect()
    {
        // Increase the player's score
        GameManager.instance.IncreaseScore(scoreValue);

        // Optionally, you can play a sound or particle effect here

        // Destroy the collectible object
        Destroy(gameObject);
    }
}

