using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageImageManager : MonoBehaviour {

    public static float delay = 0.5f;

    public GameObject StageImage;

    private GameObject Main;

    private GameObject Next;

    public GameObject canvas;

    public static bool canMove;

	// Use this for initialization
	void Start () {
        Main = Instantiate(StageImage, new Vector3(0, 0, 0), Quaternion.identity);

        Main.transform.SetParent(canvas.transform, false);

        canMove = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StagePuls()
    {
        if (canMove) { 

        canMove = false;

        Next = Instantiate(StageImage, new Vector3(550, 0, 0), Quaternion.identity);

        Next.transform.SetParent(canvas.transform, false);

        StageImage main = Main.GetComponent<StageImage>();

        main.PlusMove();

        Destroy(Main, delay);

        StageImage next = Next.GetComponent<StageImage>();

        next.PlusMove();

        Main = Next;

        StartCoroutine(MovwOdd());

        }
    }

    public void StageMinus()
    {
        if (canMove) {

            canMove = false;

            Next = Instantiate(StageImage, new Vector3(-550, 0, 0), Quaternion.identity);

            Next.transform.SetParent(canvas.transform, false);

            StageImage main = Main.GetComponent<StageImage>();

            main.MinusMove();

            Destroy(Main, delay);

            StageImage next = Next.GetComponent<StageImage>();

            next.MinusMove();

            Main = Next;

            StartCoroutine(MovwOdd());

        }
    }

    IEnumerator MovwOdd() {

        yield return new WaitForSeconds(delay);

        canMove = true;

    }

}
