using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                //유니티 UI에 접근하기위해 사용

public class ExPlayer : MonoBehaviour
{
    public int Hp = 100;
    public Text TextUI = null;

    // Update is called once per frame
    void Update()
    {
        TextUI.text = Hp.ToString();     //UIdp에 체력 표시

        if (Input.GetMouseButtonDown(0)) //마우스 왼쪽 입력이 되었을 때 조건
        {
            Hp -= 10;                    //Hp = Hp - 10
            if (Hp <= 10)                 //체력이 0이하가 되면 파괴된다.
            {
                TextUI.text = Hp.ToString();    //UI에 체력 표시
                Destroy(gameObject);    //gameObject는 스크립트가 붙어있는 오브젝트를 지칭
            }
        }
    }
}
