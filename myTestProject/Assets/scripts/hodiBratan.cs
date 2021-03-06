﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hodiBratan : MonoBehaviour {
    float horizontalSpeed;
    float speedX;
    float verticalImpulse;
    Rigidbody2D rb;
    bool isGrounded;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        horizontalSpeed = 0.1f;
        verticalImpulse = 5;
    }
	
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.A)){
            speedX = -horizontalSpeed;
        }else if (Input.GetKey(KeyCode.D)){
            speedX = horizontalSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded){
            rb.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);
        }
        transform.Translate(speedX,0,0);
        speedX = 0;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}