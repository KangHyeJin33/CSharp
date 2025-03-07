using UnityEngine;

// dowhile문을 이용해서 1부터 100(n)까지의 정수중에서 홀수의 합을 구하는 프로그램 구현.
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0; // 결과를 저장하는 변수 선언.
        int n = 100;

        //[1] 초기식
        int i = 1;

        do
        {
            //반복 실행문
            if (i % 2 == 1) // 홀수 판별식.
            {
                sum += i; // sum + i
            }

            //[3] 증감식
            i++;
        }
        while (i <= n); //[2] 조건식

        Debug.Log($"1부터 {n}까지의 홀수의 합 : {sum}");
    }
}
