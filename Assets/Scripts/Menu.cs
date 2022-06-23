using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStart() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ClickQuit() 
    {
        Application.Quit();
    }

    public void ClickRestart() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ClickExit() 
    {
        SceneManager.LoadScene("MainMenu");
    }
}
