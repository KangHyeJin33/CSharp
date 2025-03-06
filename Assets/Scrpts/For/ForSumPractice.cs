using UnityEngine;

public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;
        int sum1 = 0;
        int sum2 = 0;

        for(int i=0; i<n+1; i++)
        {
            if(i % 3 == 0)
            {
                sum = sum + i;
                
            }
           
            if (i % 4 == 0)
            {
                sum1 = sum1 + i;
                
            }
            if(i % 3 == 0 || i % 4 ==0)
            {
                sum2 = sum2 + i;
            }
           
        }
        Debug.Log($"3의 배수 합 : {sum}");
        Debug.Log($"4의 배수 합 : {sum1}");
        Debug.Log($"3의 배수와 4의 배수의 합 : {sum2}");
    }
}
/*
 [Q]
1부터 100까지의 정수중에서 3의 배수 또는 4의 배수를 구해서 합하는 프로그램 구현.

[Output]
합은 {}
 */