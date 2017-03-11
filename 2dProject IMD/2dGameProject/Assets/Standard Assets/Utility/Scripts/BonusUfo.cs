using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusUfo : MonoBehaviour
{

    public float speed;
    public float cutOffpoint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float move = speed * Time.deltaTime;
        transform.Translate(Vector2.right* 1 * move);
        if(transform.position.x >= cutOffpoint)
        {
            Destroy(gameObject);
        }
        
    }
}


