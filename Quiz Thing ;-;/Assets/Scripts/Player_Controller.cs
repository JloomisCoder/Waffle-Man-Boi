using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

    Rigidbody2D rb; // Declared but not initialized
    public float accelerationMagnitude, resistance, maxSpeed, acceleration;
    //Vector3 velocity;

	// Use this for initialization
	void Start () 
	{
        rb = GetComponent<Rigidbody2D>();
        accelerationMagnitude = 0.005f;
        resistance = 0.99f;
       // velocity = new Vector3(0.0f, 0.0f, 0.0f);
	}

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector2 originalVelocity = rb.velocity;

        if (hAxis > 0)
        {
            originalVelocity.x = Mathf.Clamp(originalVelocity.x + acceleration, 0.0f, maxSpeed);
        }
        else if(hAxis < 0)
        {
            originalVelocity.x = Mathf.Clamp(originalVelocity.x - acceleration, -maxSpeed, 0.0f);
        }

        if (vAxis > 0)
        {
            originalVelocity.y = Mathf.Clamp(originalVelocity.y + acceleration, 0.0f, maxSpeed);
        }
        else if (vAxis < 0)
        {
            originalVelocity.y = Mathf.Clamp(originalVelocity.y - acceleration, -maxSpeed, 0.0f);
        }
        //transform.position = transform.position + velocity;
        //velocity = velocity * resistance;
        rb.velocity = originalVelocity;
        
        

    }
}
