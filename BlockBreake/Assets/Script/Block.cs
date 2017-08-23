using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    //public GameObject Score;

    void OnCollisionEnter2D (Collision2D col)
    {
        //Score SC = Score.GetComponent<Score>();

        Score.score += 10;

        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
