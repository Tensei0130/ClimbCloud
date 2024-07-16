using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        //FPs60を設定
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //マウスがクリックされたら動かす
        if(Input.GetMouseButtonDown(0))
        {
            //スタートポジション設定
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButton(0))
        {
            //マウスの座標
            Vector2 endPos = Input.mousePosition;
            //移動距離を設定
            float swaipeLength = endPos.x - this.startPos.x;
            //スワイプの長さを初速度に変換する
            this.speed = swaipeLength / 500.0f;
            //効果音再生
            GetComponent<AudioSource>().Play();
        }
        //移動させる
        transform.Translate(this.speed, 0, 0);
        //減速
        this.speed *= 0.98f;
    }
}
