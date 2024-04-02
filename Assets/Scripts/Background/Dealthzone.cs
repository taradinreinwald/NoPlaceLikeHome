using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TarodevController;
using UnityEngine.SceneManagement;


public class Dealthzone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)

    {

        // Check if the colliding object has the PlayerController component

        PlayerController player = other.GetComponent<PlayerController>();

        // If the colliding object has the PlayerController component

        if (player != null)

        {

            // Restart the level

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }

}

