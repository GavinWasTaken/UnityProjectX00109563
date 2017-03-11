using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ExitGame : MonoBehaviour {

    public Canvas menu;
    public Button exit;
    

    public void exitGame()
    {
        AlienDeathCounter.counter = 65;
            Application.Quit();
    }
}
