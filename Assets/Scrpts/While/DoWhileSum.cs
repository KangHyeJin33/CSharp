using UnityEngine;

// dowhile���� �̿��ؼ� 1���� 100(n)������ �����߿��� Ȧ���� ���� ���ϴ� ���α׷� ����.
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0; // ����� �����ϴ� ���� ����.
        int n = 100;

        //[1] �ʱ��
        int i = 1;

        do
        {
            //�ݺ� ���๮
            if (i % 2 == 1) // Ȧ�� �Ǻ���.
            {
                sum += i; // sum + i
            }

            //[3] ������
            i++;
        }
        while (i <= n); //[2] ���ǽ�

        Debug.Log($"1���� {n}������ Ȧ���� �� : {sum}");
    }
}
