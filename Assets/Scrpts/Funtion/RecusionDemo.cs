using UnityEngine;

// 팩토리얼 구하는 알고리즘(4!)
public class RecusionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Hi();
        // 4! = 1 * 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);

        //For Fatorial
        Debug.Log(FactorialFor(4));

    }

    //For문 이용 Fatorial 값 구하기
    int Factorial(int n)
    {
        int result = 1; // 곱하기 누적 값은 1부터 시작.

        for(int i = 1; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }
    // 재귀함수 이용 Factorial값 구하기.
    int FactorialFor(int n)
    {
        if(n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }


}

/*
재귀함수 : 함수가 자신의 코드 블록 안에서 자기 자신을 다시 호출(재귀 호출)하는 함수.
ex.
void Hi() //함수가 자신의 코드 블록 안에서
{
    Hi(); //자기 자신을 다시 호출(재귀 호출)하는. 무한 루프.
}
- 재귀함수의 매개변수 : 매개변수는 감산, 가산이 된다.
- 재귀함수 코드 블록 안에는 재귀함수를 종료 할 수 있는 조건이 필요하다.(무한루프 종료)
 */