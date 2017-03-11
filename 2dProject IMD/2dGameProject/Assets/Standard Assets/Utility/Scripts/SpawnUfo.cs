using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUfo : MonoBehaviour {

    public GameObject Ufo;
    public Transform UfoSpawn;
    public float counter;
    public float spawnTime;
    bool hasAppeared;

    // Use this for initialization
    void Start () {
        hasAppeared = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(!hasAppeared)
            {
            counter += Time.deltaTime;
            if (counter > spawnTime)
            {

                Instantiate(Ufo, UfoSpawn.position, UfoSpawn.rotation);
                hasAppeared = true;
                counter = 0;
            }
            else
            {
                return;
            }
        }
        
    }
}
