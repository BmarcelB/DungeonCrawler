using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winbox : MonoBehaviour {

	// Use this for initialization
	public void OnTriggerEnter(Collider other) {
        GameObject.Find("Player").SendMessage("Finish");
		
	}
	
	// Update is called once per frame
	
}
