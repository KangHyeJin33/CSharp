using System.Threading;
using UnityEngine;


// 1���� 5���� 1�� �����ϸ鼭 ���� ����ϴ� ���α׷�
// Count: 1
// Count: 2
// Count: 3
// Count: 4
// Count: 5
public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*for(int count = 0; count < 5; count++)
        {
            Debug.Log($"Count:{count + 1}"); // �ݺ����๮.
        }*/

        /* for (int i = 1; i <= 5; i++)
        {
            Debug.Log($"Count:{i}");

        }*/

        for(int i = 1; i < 6; i++)
        {
            Debug.Log($"Count:{i}");
        }
    }
}
