using UnityEngine;

// 1부터 20까지의 합을 구하는 프로그램 구현.
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
        Debug.Log($"합(Sum)은 {sum}");*/

        // 1부터 n까지의 합을 구하는 프로그램 구현.
        for (int i = 1; i < n+1; i++)
        {
            sum = sum + i;
        }
        Debug.Log($"합(Sum)은 {sum}");
    }
}
