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
        //FPs60��ݒ�
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //�}�E�X���N���b�N���ꂽ�瓮����
        if(Input.GetMouseButtonDown(0))
        {
            //�X�^�[�g�|�W�V�����ݒ�
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButton(0))
        {
            //�}�E�X�̍��W
            Vector2 endPos = Input.mousePosition;
            //�ړ�������ݒ�
            float swaipeLength = endPos.x - this.startPos.x;
            //�X���C�v�̒����������x�ɕϊ�����
            this.speed = swaipeLength / 500.0f;
            //���ʉ��Đ�
            GetComponent<AudioSource>().Play();
        }
        //�ړ�������
        transform.Translate(this.speed, 0, 0);
        //����
        this.speed *= 0.98f;
    }
}
