using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExCubePlayer : MonoBehaviour
{
    public Text TextUI = null;              //텍스트 UI
    public int Count = 0;                   //마우스 클릭 카운터
    public float Power = 100.0f;            //물리 힘 수치
    public Rigidbody m_Rigidbody;           //오브젝트의 강체

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //스페이스바를 눌렀을 때
        {
            Count += 1;                                 //마우스가 클릭되었을때 Count를 1씩 올린다.
            TextUI.text = Count.ToString();                 //UI 갱신
            Power = Random.Range(100, 200);                 // 100 ~ 200 사이의 값의 힘을 준다.
            m_Rigidbody.AddForce(transform.up * Power);     //Y축으로 설정한 힘을 준다.
        }
        
        if(gameObject.transform.position.y >= 2 || gameObject.transform.position.y <= -2)
        {   //오브젝트의 y값이 -2 이하이거나 2이상일경우 조건문
            TextUI.text = "실패";
            Count = 0;                                  //실패시 카운터 초기화
        }
    }
}