using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlienDeathCounter : MonoBehaviour {

    public static int counter = 65;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(counter <= 0)
        {
            SceneManager.LoadScene("You Win!");
        }
	}
}
