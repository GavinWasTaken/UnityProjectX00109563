using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerShot : MonoBehaviour {

    public GameObject Lazer;
    public Transform LazerSpawn;
    public float fireRate;
    public AudioClip shootAudio;


    private float nextFire;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Jump") && Time.time > nextFire)
        {
            AudioSource shootAudio = GetComponent<AudioSource>();
            nextFire = Time.time + fireRate;
            Instantiate(Lazer, LazerSpawn.position, LazerSpawn.rotation);
            shootAudio.Play();
        }
	}
}
