using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    // Use this for initialization
    public static bool GameisPaused = false;

    public GameObject PauseMenuUI;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        { 
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
      
	}
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel); 
    }
}
