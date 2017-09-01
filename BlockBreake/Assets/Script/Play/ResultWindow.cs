using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultWindow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Result() {
        iTween.ScaleTo(this.gameObject,iTween.Hash("x", 1));
    }

    public void ResultEnd()
    {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 0,"easeType", "easeInBack"));
    }
}
