using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.ScaleTo(this.gameObject, iTween.Hash("y", 1));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameOverMove() {
        iTween.ScaleTo(this.gameObject, iTween.Hash("y", 0));
    }
}
