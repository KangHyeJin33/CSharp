using UnityEngine;

// 1, 2, 3, 4, 5
// 5, 4, 3, 2, 1
public class ForCountDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 5;

        //[1] 1���� 5���� 1�� ����
        for(int i = 1; i < n+1; i++)
        {
            Debug.Log($"���� Countdown : {i}");
        }
        Debug.Log("==================================");

        //[2] 5���� 1���� 1�� ����
        for (int j = 0; j < n; j++)
        {
            Debug.Log($"���� Countdown : {(5 - j)}");
        }
    }
}
