using System.Threading;
using UnityEngine;


// 1부터 5까지 1씩 증가하면서 값을 출력하는 프로그램
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
            Debug.Log($"Count:{count + 1}"); // 반복실행문.
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
