using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}


public class PlayerController : MonoBehaviour {

    public float movementSpeed;
    public Boundary boundary;
    
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxisRaw("Horizontal");

        var movement = new Vector2(x, 0.0f);
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = movement * movementSpeed;

        rigidbody.position = new Vector2
        (
            Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rigidbody.position.y, boundary.yMin, boundary.yMax)
            
            );

        

        

	}

    
}
