using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Add(5, 3);
        int result = Add(5, 3);
        Debug.Log($"3 + 5 = {result}"); // [1]
        //Debug.Log(result); [2]

        Sub(5, 3);
        Mul(5, 3);
        Dev(5, 3);
        Rem(5, 3);

    }

    /* void Add(int a, int b)
    {
        Debug.Log($"{a} + {b} = {a + b}" );
    }*/
    int Add(int a, int b)
    {
        return a + b;
    }

    /*
    [1]*/ void Sub(int a, int b)
    {
        Debug.Log($"{a} - {b} = {a - b}" );
    }
    /*[2] void Sub(int a, int b) => x - y; // 화살표 함수 또는 람다식 또는 축약형 함수라고 한다.
    */

    void Mul(int a, int b)
    {
        Debug.Log($"{a} * {b} = {a * b}");
    }

    void Dev(int a, int b)
    {
        Debug.Log($"{a} / {b} = {a / b}");
    }

    void Rem(int a, int b)
    {
        Debug.Log($"{a} % {b} = {a % b}");
    }
}

/*
[Q]
사칙연산( +, -, *, /, % )을 구하는 함수 만들기. 4개. 나머지( % ).
두 개의 정수를 입력 받아  +, -, *, /, % 계산하여 결과값을 반환하는 함수 만들기.
Add, Subtract, Multply, Devide, Remainder.

입력값 : 5, 3

[OutPut]

 */