using UnityEngine;

// ���� ����, ���� ����
public class FunctionScope : MonoBehaviour
{
    string message = "���� ����"; // �ʵ�. ��� ����. ��������.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string Message = "���� ����"; // ��������.    

        ShowMessage();
        PrintMessage();

        Debug.Log(message);
    }

    // message�� ����ϴ� �Լ�.
    void ShowMessage()
    {
        string msg = "���� ����"; //= string massege = "���� ����";
        Debug.Log(msg); //(msg) = (massege)
    }

    void PrintMessage()
    {
        //Debug.Log(msg); // ���� : 'PrintMessage()'�� 'msg'�� �𸥴�. 'ShowMessage()'�� �ڵ���(����)������ ��ȿ�ϱ� ������.
        Debug.Log(message);
    }
}
