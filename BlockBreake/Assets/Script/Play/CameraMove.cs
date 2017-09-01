using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public float moveRanage = 1f;

    public float time = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Damage() {
        iTween.ShakePosition(this.gameObject, iTween.Hash("x", moveRanage, "y", moveRanage,  "time", time));
    }
}
