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
        Debug.Log($"3�� ��� �� : {sum}");
        Debug.Log($"4�� ��� �� : {sum1}");
        Debug.Log($"3�� ����� 4�� ����� �� : {sum2}");
    }
}
/*
 [Q]
1���� 100������ �����߿��� 3�� ��� �Ǵ� 4�� ����� ���ؼ� ���ϴ� ���α׷� ����.

[Output]
���� {}
 */