using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movment : MonoBehaviour {
    public float forwardForce = 8000f;
    public float sidewaysForce = 600f;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb.AddForce(0,10,1500);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0,0,1000 * Time.deltaTime);

        if (Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, 1500 * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -1500 * Time.deltaTime);
        }
        
    }
}
