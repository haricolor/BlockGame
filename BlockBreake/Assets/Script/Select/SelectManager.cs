using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour {

    public static int stageNum;

    public GameObject Right;
    public GameObject Left;

    public GameObject StageImages;

    // Use this for initialization
    void Start () {
        stageNum = 0;

        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 1 ,"y", 1));
	}
	
	// Update is called once per frame
	void Update () {

        StageImage SI = StageImages.GetComponent<StageImage>();

        if (stageNum == SI.Stages.Length - 1)
        {
            Right.SetActive(false);
        }
        else {
            Right.SetActive(true);
        }

        if (stageNum == 0)
        {
            Left.SetActive(false);
        }
        else
        {
            Left.SetActive(true);
        }
    }

    public void StagePlus() {
        if (StageImageManager.canMove) {
            stageNum++;
        }
    }

    public void StageMinus(){
        if (StageImageManager.canMove) {
            stageNum--;
        }
        
    }
}
