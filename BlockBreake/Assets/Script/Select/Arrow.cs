using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    public float DefaultSize = 1f;
    public float MaxSize = 1.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Enter(){
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", MaxSize, "y", MaxSize));
    }

    public void Exit() {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", DefaultSize, "y", DefaultSize));
    }

    public void push() {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", DefaultSize, "y", DefaultSize));

        iTween.ScaleTo(this.gameObject, iTween.Hash("x", MaxSize, "y", MaxSize));
    }

}
