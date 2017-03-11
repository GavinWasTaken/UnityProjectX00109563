using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyDestroy : MonoBehaviour {

    public int scoreValue;
    public AudioClip deathsound;
    AlienDeathCounter counter;
    
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
        else if(other.tag == "shield")
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
            AlienDeathCounter.counter = AlienDeathCounter.counter - 1;
            ScoringManager.score += scoreValue;
            if(AlienDeathCounter.counter <= 0)
            {
                
                SceneManager.LoadScene("You Win!");
                AlienDeathCounter.counter = 65;
            }
        }
            
    }

    
}
