using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int maxValue = GetMax(3, 5);
        Debug.Log($"3과 5 중 큰 수는 {maxValue}입니다.");

        float minValue = GetMin(-3f, -5f);
        Debug.Log($"-3과 -5 중 작은 수는 {minValue}입니다.");

    }

    int GetMax(int a, int b)
    {
    

        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    float GetMin(float x, float y)
    {
        

        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
    //3항 연산자
    //int maxValue = (x > y) ? x : y; // 조건식이 참이면 x를 반환, 조건식이 거짓이면 y를 반환.
    //retrun maxValue;

    //retrun (x > y) ? x : y

    }

/*
[Q]
1. 매개변수로 입력 받은 두 개의 정수 중 큰 수를 반환 하는 함수.
2. 매개변수로 입력 받은 두 개의 정수 중 작은 수를 반환 하는 함수.
3. (3, 5)를 입력 받아 큰 수 출력하기.
4. (-3, -5)를 입력 받아 작은 수 출력하기.

[OutPut]
3과 5 중 큰 수는 (반환 값)이다.
-3과 -5 중 작은 수는 (반환 값)이다.
 */
