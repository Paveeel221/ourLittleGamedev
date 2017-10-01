using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hodiBratan : MonoBehaviour {
    float horizontalSpeed;
    float speedX;
    float verticalImpulse;
    Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.A)){
            speedX = -horizontalSpeed;
        }else if (Input.GetKey(KeyCode.D)){
            speedX = horizontalSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space)){

        }
	}
}
