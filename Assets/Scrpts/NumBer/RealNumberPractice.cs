using UnityEngine;

public class RealNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float fnumber = 3.14f;
        double Dnumber = 3.14d;
        decimal DDnumber = 3.14m;

        Debug.Log("Float : " + fnumber);
        Debug.Log("double : " + Dnumber);
        Debug.Log("decimal : " + DDnumber);

    }
}
/*
 [Q]
실수형 값 float 3.14, double 3.14, decimal 3.14 값 출력하기.

[output]
float : 3.14
double : 3.14
decimal : 3.14
 */