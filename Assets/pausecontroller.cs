using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausecontroller : MonoBehaviour {

    public bool paused;
	void Start () {
        paused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            paused = !paused;
        }
        if (paused)
        {
            Time.timeScale = 0;
        }
        if (!paused)
        {
            Time.timeScale = 1;
        }
	}
}
