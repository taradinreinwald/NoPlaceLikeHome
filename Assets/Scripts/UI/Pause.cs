using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update
    
    public void Stop()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Closed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScreen");
    }
    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void OnPause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnPause();


        }

    }
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
