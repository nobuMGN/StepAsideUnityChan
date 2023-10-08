using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoroyContoroler : MonoBehaviour
{
    //カメラののオブジェクト
    private GameObject maincamera;
    //カメラとアイテムの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //カメラのオブジェクトを取得
        this.maincamera = GameObject.Find("Main Camera");
        //カメラとアイテムの位置（z座標）の差を求める
        this.difference = maincamera.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (maincamera.transform.position.z > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
