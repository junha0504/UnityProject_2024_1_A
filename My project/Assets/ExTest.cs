using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTest : MonoBehaviour
{
    public int Hp = 100;           //체력 100선언
    public float height = 180.5f;  //높이 180.5 선언

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Hp);
        Debug.Log(height);
    }
}
