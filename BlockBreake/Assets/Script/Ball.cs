using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public int speed = 30;


    // Use this for initialization
    void Start () {
        Rigidbody2D Rb = GetComponent<Rigidbody2D>();

        //右上にボールを動かすs
        Rb.AddForce((transform.up + transform.right) * speed);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Damage")
            Life.life --;
    }

}
