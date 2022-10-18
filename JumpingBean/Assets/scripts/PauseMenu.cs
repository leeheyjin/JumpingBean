using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUI;
    private bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        PauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }

        if(paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if(!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void Resume()
    {
        paused = !paused;
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Home()
    {
        SceneManager.LoadScene("Start");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
