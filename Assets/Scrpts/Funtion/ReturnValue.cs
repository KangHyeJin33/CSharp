using UnityEngine;

// ��ȯ���� �ִ� �Լ� ����� ȣ���ϱ�
public class ReturnValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ��ȯ���� �ִ� �Լ� ȣ��(���)
        // ��ȯ���� �޾��� ���� ����.
        string returnVaue = GetString();
        Debug.Log(returnVaue);
    }
        
    

    //[1] ��ȯ���� �ִ� �Լ� �����(����, ����)
    // ��ȯ���̶�� string(���ڿ�)�� ��ȯ�ϴ� �Լ�.
    string GetString()
    {
        return ("��ȯ��(RetrunValue)");
    }
}
