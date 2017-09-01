using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour {

    public float defaultSize = 0.5f;

    public float maxSize = 0.7f;

    public float time = 0.5f;

    public float outPosition = 510f;

    public float inPosition = 0f;

    // Use this for initialization
    void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnterPoint()
    {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", maxSize * 2, "y", maxSize, "time", time));
    }

    public void ExitPoint()
    {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", defaultSize * 2, "y", defaultSize, "time", time));
    }

    public void MoveOut() {
        iTween.MoveTo(this.gameObject, iTween.Hash("x", outPosition, "easetype", "easeInBack", "isLocal", true));
    }

    public void MoveIn() {
        iTween.MoveTo(this.gameObject, iTween.Hash("x", inPosition, "easetype", "easeOutBack", "isLocal", true));
    }
}
