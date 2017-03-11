using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AlienWaveMovement : MonoBehaviour {

    public float speed;
    public float  dir = 1;
    public float setBoundaryRight;
    public float setBoundaryLeft;
    public float moveDown;

    

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * dir * speed * Time.deltaTime);
        Vector2 pos = transform.position;
        if (transform.position.x >= setBoundaryRight)
        {
            dir = -1;
            pos.y -= moveDown;
            transform.position = pos;
            speed = speed + 0.2f;
        }
        else if (transform.position.x <= setBoundaryLeft)
        {
            dir = 1;
            pos.y -= moveDown;
            transform.position = pos;
            speed = speed + 0.2f;
        }
	}
}
