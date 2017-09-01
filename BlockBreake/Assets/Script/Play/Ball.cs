using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public int speed = 30;

    public GameObject Camera;

    public AudioClip DamageSound;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 1, "y", 1));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart() {
        Rigidbody2D Rb = GetComponent<Rigidbody2D>();

        //右上にボールを動かすs
        Rb.AddForce((transform.up + transform.right) * speed);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Damage") {
            Life.life--;

            CameraMove CM = Camera.GetComponent<CameraMove>();

            CM.Damage();

            audioSource = gameObject.GetComponent<AudioSource>();

            audioSource.clip = DamageSound;

            audioSource.Play();
        }
    }

    public void GameOverMove() {

        Rigidbody2D RD = this.gameObject.GetComponent<Rigidbody2D>();

        RD.velocity = Vector3.zero;
        //RD.angularVelocity = Vector3.zero;

        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 0, "y", 0));
    }

}
