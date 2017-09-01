using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageImage : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;

    public Sprite[] Stages;

    private int stageNum;

	// Use this for initialization
	void Start () {
        Image ThisImage = gameObject.GetComponent<Image>(); 

        ThisImage.sprite = Stages[SelectManager.stageNum];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlusMove() {
        iTween.MoveAdd(this.gameObject,iTween.Hash("x", -550,"time", StageImageManager.delay, "isLocal", true));
    }

    public void MinusMove()
    {
        iTween.MoveAdd(this.gameObject, iTween.Hash("x", 550, "time", StageImageManager.delay, "isLocal", true));
    }

    public void Enter() {
        iTween.ScaleTo(this.gameObject,iTween.Hash("x", 1.3f,"y", 1.3f));
    }

    public void Exit() {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 1f, "y", 1f));
    }

    public void Play() {
        SceneManager.LoadScene("Play");
    }
}
