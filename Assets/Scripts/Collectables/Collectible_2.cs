using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class Collectible_2 : MonoBehaviour

{
    public int scoreValue = 10; // Score value of each collectible
    private PlayerController playerController; // Reference to the PlayerController
    bool isPlayerNearby;
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
            if (isPlayerNearby)
            {
                Collect();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding GameObject is the player
        if (other.gameObject.GetComponent<PlayerController>())
        {

            isPlayerNearby = true;


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

