using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageText : MonoBehaviour {

    public Text text;

    private int Stage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Stage = SelectManager.stageNum + 1;
        text.text = "STAGE  " + Stage;
	}
}
