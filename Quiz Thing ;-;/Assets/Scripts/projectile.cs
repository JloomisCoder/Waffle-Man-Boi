using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

    public Vector3 velocity;
    public float velocityMagnitude;
    public float direction;
    float timeStart;

	// Use this for initialization
	void Start ()
    {
        timeStart = Time.time;
	}
	
    public void calculateVelocity()
    {
        
    }

	// Update is called once per frame
	void Update () {
		
	}
}
