using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Vector3 pos;
    private Vector3 WorldPointPos;

    public float MaxX = 3.3f;
    public float MinX = -7.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Move();

	}

    public void Move()
    {
        //マウス位置座標をVector3で取得
        pos = Input.mousePosition;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        WorldPointPos = Camera.main.ScreenToWorldPoint(pos);

        // 壁を突き抜けないようにx軸の移動範囲を限定

        if (WorldPointPos.x <= MinX)
        {
            WorldPointPos.x = MinX;
        }
        else if (WorldPointPos.x >= MaxX)
        {
            WorldPointPos.x = MaxX;
        }
        
        //y軸とz軸は固定
        WorldPointPos.y = -4.7f;
        WorldPointPos.z = 0.0f;

        // ワールド座標をPlayer位置へ変換
        gameObject.transform.position = WorldPointPos;
    }
}
