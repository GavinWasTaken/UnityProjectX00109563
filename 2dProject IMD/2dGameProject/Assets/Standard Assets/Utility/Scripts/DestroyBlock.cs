using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour {

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        else if(other.tag == "Alien")
        {
            Destroy(gameObject);
        }
        else if (other.tag == "Lazer" || other.tag == "EnemyLazer")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
            
    }
}
