using UnityEngine;

// &&, ||
public class IfEnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;

        // ���ǽ��� �ΰ��� �϶�. 1. number�� 1234�� ������?. 2. number�� 1000�̻� ����?)
        // �ΰ��� ������ ��� �����ϸ�(&&) �½��ϴ�.���.
        if(number == 1234 && number >= 1000)
        {
            Debug.Log("�½��ϴ�.");
        }

        // ���ǽ��� �ΰ��� �϶�. 1. number�� 1234�� ������?. 2. number�� 1000���� ����?)
        // �ΰ��� ���� �� �ϳ��� �����ϸ�(||) ���๮ ����.
        if(number == 1234 || number <= 1000)
        {
            Debug.Log("�ϳ��� ���̸� ��");
        }
    }
}
