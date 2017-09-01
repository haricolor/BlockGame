using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {

    public GameObject Block;

    public GameObject ball;

    public GameObject[] StageBlocks;

    public int i;

	// Use this for initialization
	void Start () {

        i = 0;

        Stage1();

        switch (SelectManager.stageNum) {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }

        Ball B = ball.GetComponent<Ball>();

        B.GameStart();
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void Stage1() {
        StageBlocks = new GameObject[15];

        for (int y = 4 ; y > 1 ; y-- ) {
            for (int x = -4 ; x < 6 ; x += 2) {
                StageBlocks[i] = Instantiate(Block, new Vector3(x, y, 0), Quaternion.identity);

                StageBlocks[i].transform.SetParent(this.gameObject.transform, false);

                i++;
            }
        }
    }

    public void GameOverMove() {
        for (int n = 0; n < StageBlocks.Length ; n++) {
            if (StageBlocks[n] != null) {
                Block B = StageBlocks[n].GetComponent<Block>();

                B.GameOverMove();
            }
        }
    }
}
