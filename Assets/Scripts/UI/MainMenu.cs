using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{
    private bool _controlsOpen = false;

    [SerializeField]
    private GameObject _controls;

    [SerializeField]
    private GameObject _startButton;

    [SerializeField]
    private GameObject _closeButton;

    private void Awake()
    {
        _controls = GameObject.Find("Controls"); // Finds the Controls Button

        _startButton = GameObject.Find("ResumeButton"); // Finds the Start Button

        _closeButton = GameObject.Find("CloseButton"); // Finds the Start Button
    }
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

