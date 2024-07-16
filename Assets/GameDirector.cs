using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    //車オブジェクト
    GameObject car;
    //フラグのオブジェクト
    GameObject flag;
    //距離のオブジェクト
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
        //距離を測り表示する
        float length = this.flag.transform.position.x-this.car.transform.position.x;

        //テキストに表示
        this.distance.GetComponent<TextMeshProUGUI>().text = "distance:" + length.ToString("F2") + "m";
    }
}
