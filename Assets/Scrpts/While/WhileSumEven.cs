using UnityEngine;

// while���� �̿��ؼ� 1���� 100(n)������ �����߿��� ¦���� ���� ���ϴ� ���α׷� ����.
public class WhileSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0; // ����� �����ϴ� ���� ����.
        int n = 100;

        //[1] �ʱ��
        int i = 1;

        while (i <= n) //[2] ���ǽ�
        {
            //�ݺ� ���๮
            if(i % 2 == 0) // ¦�� �Ǻ���.
            {
                sum += i; // sum + i
            }

            //[3] ������
            i++;
        }
        Debug.Log($"1���� {n}������ ¦���� �� : {sum}");
    }
}
