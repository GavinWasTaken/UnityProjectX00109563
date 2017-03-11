using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour {
    AlienDeathCounter counter;
    public void LoadScene(int level)
    {
        AlienDeathCounter.counter = 65;
        SceneManager.LoadScene(level);
    }
	
}
