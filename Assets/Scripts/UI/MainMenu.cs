using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{
    

    
    void Start()
    {
  
      
       

    }

    void Update()
    {

       
    }

    public void OnStartPress()
    {
        SceneManager.LoadScene("Level_Canada"); // Loads level 1
    } 
    public void OnQuitPress()
    {
        Debug.Log("Quitting game...");
        Application.Quit(); // Quits the game
    }
   
}

