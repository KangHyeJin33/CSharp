using UnityEngine;

// DefaultParamitor(�⺻ �Ű�����, ������ �Ű�����) : �Ű����� ����� ���ÿ� �ʱ�ȭ�� �Ѵ�.
// ������ �Ű������� �Լ� ȣ�� �� ���� �����ϴ�. ���� �� �ʱ�ȭ �� ���� ���Ǿ�����.
public class defaultParamitor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {/*
        //�Ű������� ���� �Լ� ȣ��.
        PrintMessage();

        //�Ű������� �ִ� �Լ� ȣ��.
        string error = "�����";
        PrintError(error);

        //��ȯ���� �ִ� �Լ� ȣ��
        string errorlog = PrintLog();
        Debug.Log(errorlog);*/

        PrintError("�����", 4);
        PrintError("�����"); // ������ �Ű������� 'PrintError("�����", 1);'�� ����.
    }

    // Message�� ����ϴ� �Լ�.
    void PrintMessage()
    {
        string message = "�����";
        Debug.Log(message);
    }
    void PrintError(string message, int level = 1) // ������ �Ű����� �޴°� ������ (int level = 1) ���� �ʱⰪ(1) ����.
    {
        Debug.Log($"���� : {message}, ���� :{level}"); //������ n������ ��, ���� �޼��� �߻�.
    }

    string PrintLog()
    {
        string log = "����� �α�";
        return log;
    }
}
