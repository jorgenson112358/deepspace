using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public Transform target_object;
	public float follow_tightness;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    	// Update is called once per frame
	void FixedUpdate () {
        Vector3 wanted_position;

		wanted_position = target_object.position;
		wanted_position.z = transform.position.z;
		transform.position = Vector3.Lerp(transform.position, wanted_position, Time.deltaTime * follow_tightness);
		
	}
}
