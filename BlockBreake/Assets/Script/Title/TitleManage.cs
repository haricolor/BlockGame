using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManage : MonoBehaviour {
    public int choice = 0;
    public GameObject[] element;

	// Use this for initialization
	void Start () {

        StartCoroutine(Title(0.5f));
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Choice(int moode) {
                StartCoroutine(ScenceMove(moode));
    }

    public IEnumerator Title(float time) {
        for (int i = 0;i < element.Length;i++) {
            Choice CH = element[i].GetComponent<Choice>();
            CH.MoveIn();
            yield return new WaitForSeconds(time);
        }
    }

    public IEnumerator ScenceMove(int num) {

        yield return new WaitForSeconds(1f);

        for (int i = 0; i < element.Length; i++){
            if (i != num) {
                Choice CH = element[i].GetComponent<Choice>();
                CH.MoveOut();
            }
        }

        yield return new WaitForSeconds(1.3f);

        switch (num)
        {
            case 0:
                SceneManager.LoadScene("Select");
                break;
            case 1:
                SceneManager.LoadScene("Play");
                break;
            case 2:

                break;
            case 3:

                break;
        }
    }

}
