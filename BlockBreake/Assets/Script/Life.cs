using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {
    public Text lifeText;
    public static int life = 0;

    // Use this for initialization
    void Start () {
        life = 3;	
	}
	
	// Update is called once per frame
	void Update () {
        lifeText.text = "" + life;
    }
}
