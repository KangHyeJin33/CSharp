using UnityEngine;

// 1부터 10(=n)까지의 정수 중 짝수의 합을 구하는 프로그램 구현. sum 출력.
// 1 + 2 + 3 + 4 + 5 ...
// 2 + 4 + 6 + 8 ...
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        int n = 10;

        /*for (int i = 1; i < n+1; i++)
        {
            sum = sum + i; // 반복실행문.

            if (sum % 2 == 0)
            {
              
                Debug.Log($"1부터 10까지의 정수 중 짝수의 합(Sum) : {sum}");
            }
            else if (sum % 2 == 1)
            {
                Debug.Log("짝수가 아닙니다.");
            }
        }*/

        for (int i = 1; i < n + 1; i++)
        {
            if (i % 2 == 0) // 짝수 판별식을 통해 짝수만 더한다.
            {
                sum = sum + i; // 반복실행문.
            }

        }
        Debug.Log($"1부터 {n}까지의 정수 중 짝수의 합(Sum) : {sum}");
    }
}
