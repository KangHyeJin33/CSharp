using UnityEngine;

// 1���� 10������ ������ ���� ���ϴ� ���α׷� ����.
// ���� ���� 22�̻��� �Ǹ� ���̻� ���� ������ �ʴ´�.
// while�� �̿�.
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;
        int i = 1;

        while(i <= n) //���ǽ�
        {
            // �ݺ� ���๮
            sum = sum + i;

            /*for(int i = 1; i < n; i++)
            {
                sum = sum + i;
            }*/

            if(sum >= goal)
            {
                break;
            }

            // ������
            i++;
        }
        Debug.Log($"1���� 10������ ������ �� : {sum}");

    }
}
