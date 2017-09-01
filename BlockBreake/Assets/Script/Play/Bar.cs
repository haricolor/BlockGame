using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour {

    public float speed = 0.1f;
    public float times = 0.3f;

    // Use this for initialization
    void Start() {
        //BI = barのimage
        Image BI = GetComponent<Image>();

        BI.fillAmount = 0;
    }

    // Update is called once per frame
    void Update() {

    }


    public void Extend() {

        //BI = barのimage
        Image BI = GetComponent<Image>();

        if (BI.fillAmount < 1) {
            while (BI.fillAmount < 1) {
                StartCoroutine(DelayF(times));
            }
        }
    }

    public void Shrink() {
        //BI = barのimage
        Image BI = GetComponent<Image>();

        if (BI.fillAmount > 0)
        {
            while (BI.fillAmount > 0)
            {
                StartCoroutine(DelayS(times));
            }
        }
    }

    IEnumerator DelayF(float time) {
        //実行を遅らせるメソッド
        Image BI = GetComponent<Image>();
        BI.fillAmount += speed;
        yield return new WaitForSeconds(time);
    }
    IEnumerator DelayS(float time)
    {
        //実行を遅らせるメソッド
        Image BI = GetComponent<Image>();
        BI.fillAmount -= speed;
        yield return new WaitForSeconds(time);
    }

    /*public IEnumerator Extend()
    {

        //BI = barのimage
        Image BI = GetComponent<Image>();

        if (BI.fillAmount < 1)
        {
            while (BI.fillAmount < 1)
            {
                BI.fillAmount += speed;
                yield return new WaitForSeconds(times);
            }
        }
    }

    public IEnumerator Shirink()
    {

        //BI = barのimage
        Image BI = GetComponent<Image>();

        if (BI.fillAmount > 0)
        {
            while (BI.fillAmount > 0)
            {
                BI.fillAmount -= speed;
                yield return new WaitForSeconds(times);
            }
        }
    }
    */
}
