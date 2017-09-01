using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public AudioClip BreakSound;

    private AudioSource audioSource;

    void OnCollisionEnter2D (Collision2D col)
    {
        Score.score += 10;

        audioSource = gameObject.GetComponent<AudioSource>();

        audioSource.clip = BreakSound;

        audioSource.Play();

        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 1, "y", 1));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameOverMove() {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 0, "y", 0));
    }
}
