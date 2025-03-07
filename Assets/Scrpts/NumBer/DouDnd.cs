using UnityEngine;

public class DouDnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //double pi = 3.141592; // (64 Bit) 실수형 데이터 형식 선언하고 초기화.
        //float f = 3.14f; // (32 Bit) 실수형 데이터 형식 선언하고 초기화.
        //decimal d = 12.34m; // (128 Bit) 실수형 데이터 형식 선언하고 초기화.

        //Debug.Log(pi);
        //Debug.Log(f);
        //Debug.Log(d);

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Debug.Log("double 최소 값 : " + doubleMin);
        Debug.Log("double 최대 값 : " + doubleMax);

        float floaMin = float.MinValue;
        float floaMax = float.MaxValue;

        Debug.Log("float 최소 값 : " + floaMin);
        Debug.Log("float 최소 값 : " + floaMax);


    }

}
/*
decimal : 계산이 float을 사용해도 정확성을 높일 때, 금융쪽에서 사용.


 */