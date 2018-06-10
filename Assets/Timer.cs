using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {
    public Text timertext;
    private float startTime;
    private bool finished = false;
    public float timer;
	// Use this for initialization
	void Start () {
        
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (finished)
            return;
        timer = Time.time - startTime;
        string minutes = ((int) timer / 60).ToString();
        string seconds = (timer % 60).ToString("f2");

        timertext.text = minutes + ":" + seconds;
    }
    public void Finish()
    {
        finished = true;
        timertext.color = Color.yellow;
        return;
        
    }
}
