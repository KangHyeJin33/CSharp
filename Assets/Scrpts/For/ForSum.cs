using UnityEngine;

// 1���� 20������ ���� ���ϴ� ���α׷� ����.
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        int n = 100;

        /*for (int i=1; i<=20;)
        { 
            sum = i++;
            Debug.Log("Sum : ", sum);
        }
        for(int i=1; i<21; i++)
        {
            sum = sum + i;
        }
        Debug.Log($"��(Sum)�� {sum}");*/

        // 1���� n������ ���� ���ϴ� ���α׷� ����.
        for (int i = 1; i < n+1; i++)
        {
            sum = sum + i;
        }
        Debug.Log($"��(Sum)�� {sum}");
    }
}
