using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDestroy : MonoBehaviour
{

    public GameObject player;
    public Transform spawnPoint;
    int currentLives;
    bool justDied;

    private void Update()
    {

        currentLives = LivesManager.lives;
    }

    IEnumerator yieldFunction()
    {
        yield return new WaitForSeconds(5);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (!justDied)
        {
            if (other.tag == "Boundary")
            {
                return;
            }
            else if (other.tag == "EnemyLazer" || other.tag == "Alien")
            {

                Destroy(other.gameObject);
                currentLives = currentLives - 1;
                LivesManager.lives = currentLives;

                justDied = true;
                yieldFunction();
                justDied = false;


                player.transform.position = spawnPoint.transform.position;
                if (currentLives <= 0)
                {
                    AlienDeathCounter.counter = 65;
                    SceneManager.LoadScene("Game Over");
                }
                else
                {
                    return;
                }

            }
            else
            {
                return;
            }


        }
    }
}
