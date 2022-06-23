using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public GameObject pause;
    public GameObject resume;
    public GameObject panel;
    public GameObject panelexit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame ()
    {   
        pause.SetActive(false);
        resume.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame ()
    {
        pause.SetActive(true);
        resume.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }

    public void no()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void yes()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Time.timeScale = 0;
        panelexit.SetActive(true);
    }

    public void noExit()
    {
        panelexit.SetActive(false);
        Time.timeScale = 1;
    }

    public void yesExit()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
