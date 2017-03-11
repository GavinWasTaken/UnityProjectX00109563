using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour {
    public static int lives;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();

        lives = 4;
}

    void Update()
    {
        text.text = "Lives: " + lives;
    }
}
