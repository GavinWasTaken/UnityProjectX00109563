using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoDeath : MonoBehaviour {


    public int scoreValue;
    public AudioClip deathsound;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Boundary")
        {
            return;
        }
        else if (other.tag == "EnemyLazer")
        {
            return;
        }
        else if (other.tag == "shield")
        {
            return;
        }
        else if (other.tag == "Alien")
        {
            return;
        }
        else if (other.tag == "Lazer")
        {
            AudioSource.PlayClipAtPoint(deathsound, transform.position);


            Destroy(other.gameObject);
            Destroy(gameObject);
            
            ScoringManager.score += scoreValue;
            
        }

    }
}
