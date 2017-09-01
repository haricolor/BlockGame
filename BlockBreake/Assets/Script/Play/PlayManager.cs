using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour {

    public GameObject ball;
    public GameObject player;
    public GameObject backGround;
    public GameObject blockManager;
    public GameObject result;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameOverMove() {
        Ball BL = ball.GetComponent<Ball>();

        BL.GameOverMove();

        BlockManager BM = blockManager.GetComponent<BlockManager>();

        BM.GameOverMove();

        Player PL = player.GetComponent<Player>();

        PL.GameOverMove();

        BackGround BG = backGround.GetComponent<BackGround>();

        BG.GameOverMove();

        ResultWindow RW = result.GetComponent<ResultWindow>();

        RW.Result();
    }


    public void ReTry() {
        ResultWindow RW = result.GetComponent<ResultWindow>();

        RW.ResultEnd();

        SceneManager.LoadScene("Play");
    }

    public void StageSelect()
    {
        ResultWindow RW = result.GetComponent<ResultWindow>();

        RW.ResultEnd();

        SceneManager.LoadScene("Select");
    }

    public void Title()
    {
        ResultWindow RW = result.GetComponent<ResultWindow>();

        RW.ResultEnd();

        SceneManager.LoadScene("Title");
    }
}
