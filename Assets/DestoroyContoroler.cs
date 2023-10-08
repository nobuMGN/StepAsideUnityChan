using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoroyContoroler : MonoBehaviour
{
    //�J�����̂̃I�u�W�F�N�g
    private GameObject maincamera;
    //�J�����ƃA�C�e���̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //�J�����̃I�u�W�F�N�g���擾
        this.maincamera = GameObject.Find("Main Camera");
        //�J�����ƃA�C�e���̈ʒu�iz���W�j�̍������߂�
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
