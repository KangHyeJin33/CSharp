using UnityEngine;

// 1���� 10(=n)������ ���� �� ¦���� ���� ���ϴ� ���α׷� ����. sum ���.
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
            sum = sum + i; // �ݺ����๮.

            if (sum % 2 == 0)
            {
              
                Debug.Log($"1���� 10������ ���� �� ¦���� ��(Sum) : {sum}");
            }
            else if (sum % 2 == 1)
            {
                Debug.Log("¦���� �ƴմϴ�.");
            }
        }*/

        for (int i = 1; i < n + 1; i++)
        {
            if (i % 2 == 0) // ¦�� �Ǻ����� ���� ¦���� ���Ѵ�.
            {
                sum = sum + i; // �ݺ����๮.
            }

        }
        Debug.Log($"1���� {n}������ ���� �� ¦���� ��(Sum) : {sum}");
    }
}
