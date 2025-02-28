using UnityEngine;

// bool(불) : 불형, 논리 자료형, 참(true), 거짓(false) 값만 저장.
public class boolDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool 변수 선언하고 초기화.
        bool bln = true;

        Debug.Log("bln : " + bln);

        bool isOut = false;

        Debug.Log("isOut : " + isOut);

    }
}
