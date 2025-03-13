using UnityEngine;

public class TryCharch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch
        {
            Debug.Log("에러가 발생 했습니다");
        }

        /*int[] arr = new int[2]; //정수형 배열 arr 변수 선언 = 요소수 크기(메모리) 2개 생성
        arr[1] = 10;*/
    }
}

/*
예외처리(Exception Handling) : Try-Catch-fially 문을 사용 
예외(오류)
1. 문법 오류
2. 런타임 오류
3. 알고리즘 오류

- 구문

try
{
    //명령문
    //명령문
    //...
}
catch
{
    //try 코드블록 안에있는 명령문들을 실행 중 예외(Exception) 발생 즉시 처리할 내용
    // ...
}

 */
