using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class PauseMenu : MonoBehaviour
{


    [SerializeField]
    private GameObject _pauseMenuScreen;

    private bool _gamePaused;

    [SerializeField]
    private GameObject _player;

    //[SerializeField]
    //private GameObject _controls;

    [SerializeField]
    private GameObject _resumeButton;

    private bool _controlsOpen = false;

    private void Awake()
    {
        _pauseMenuScreen = GameObject.Find("PauseMenuBackground"); // Finds the pause menu. Must be the background and not the PauseMenu object.

        _player = GameObject.Find("Player"); // Finds the player

        //_controls = GameObject.Find("Controls"); // Finds the Controls screen
    }
    void Start()
    {
        _pauseMenuScreen.SetActive(false); // Hides the pause menu

        //_controls.SetActive(false); // Hides the controls screen

        Cursor.lockState = CursorLockMode.Locked; // Locks the cursor

    }

    void Update()
    {

        if (_gamePaused)
        {
            if (_player != null)
                _player.SetActive(false); // Deactivate the Player object if it exists in the scene. Keeps the player character from recieving any inputs while the game is paused.
        }
        else if (!_gamePaused)
        {
            if (_player != null)
                _player.SetActive(true); // Activate the Player object if it exists in the scene
        }

        if (Input.GetKeyDown(KeyCode.Escape) && _controlsOpen == false) // After pressing escape, if the controls screen is closed...
        {
            if (!_gamePaused) // If the game is not already paused...
            {
                GamePause(); // Pause the game
            }
        }
        //else if (Input.GetKeyDown(KeyCode.Escape) && _controlsOpen == true) // After pressing escape, if the controls screen is open...
        //{
        //    {
        //        _controls.SetActive(false); // Hides the controls screen
        //    }
        //}

        if (Input.GetMouseButtonDown(0) && _gamePaused == true)
        {
            EventSystem.current.SetSelectedGameObject(EventSystem.current.firstSelectedGameObject); // If anyone accidentally clicks the screen while the game is paused, the selection will automatically return to the Resume button.
        }
    }
    public void CloseApplication()
    {
        Application.Quit();
    }

#region Pause/Resume functions
public void GamePause()
    {
        _gamePaused = true; // Sets the pause flag to true

        OpenMenu();

        Time.timeScale = 0f; // Freeze time

    }

    public void GameResume()
    {

        _gamePaused = false; // Sets the pause flag to false

        CloseMenu();

        Time.timeScale = 1f; // Resume time
    }

    private void OpenMenu()
    {
        _pauseMenuScreen.SetActive(true); // Shows the pause menu
    }

    private void CloseMenu()
    {
        _pauseMenuScreen.SetActive(false); // Hide the pause menu
    }
    #endregion

    #region Button Actions

    public void OnResumePress()
    {
        GameResume(); // Resumes the game when the Resume button is pressed.
    }

    //public void OnControlsPress()
    //{
    //    _controls.SetActive(true); // Shows the controls screen
    //    _controlsOpen = true; // Flags the controls screen as being open
    //}

    public void OnMainMenuPress()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // Loads the Main Menu scene
    }

    #endregion
}




















