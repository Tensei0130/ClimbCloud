using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    //�ԃI�u�W�F�N�g
    GameObject car;
    //�t���O�̃I�u�W�F�N�g
    GameObject flag;
    //�����̃I�u�W�F�N�g
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        //�����𑪂�\������
        float length = this.flag.transform.position.x-this.car.transform.position.x;

        //�e�L�X�g�ɕ\��
        this.distance.GetComponent<TextMeshProUGUI>().text = "distance:" + length.ToString("F2") + "m";
    }
}
