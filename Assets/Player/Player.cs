using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float acceleration_amount = 1f;
	public float rotation_speed = 1f;
    public int currentHullIntegrity = 100;
    public int maxHullIntegrity = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            //Debug.Log("speed up");
            GetComponent<Rigidbody2D>().AddForce(transform.up * acceleration_amount * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            //Debug.Log("slow down");
			GetComponent<Rigidbody2D>().AddForce((-transform.up) * acceleration_amount * Time.deltaTime);	
		}
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift)) {
			GetComponent<Rigidbody2D>().AddForce((-transform.right) * acceleration_amount * 0.6f  * Time.deltaTime);
			//print ("strafeing");
		}
		if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift)) {
			GetComponent<Rigidbody2D>().AddForce((transform.right) * acceleration_amount * 0.6f  * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.LeftShift)) {
			GetComponent<Rigidbody2D>().AddTorque(-rotation_speed  * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftShift)) {
			GetComponent<Rigidbody2D>().AddTorque(rotation_speed  * Time.deltaTime);
		}	
    }
}
