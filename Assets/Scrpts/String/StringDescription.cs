using UnityEngine;

//String Ŭ����, StringBuller Ŭ������ �̿��Ͽ� ���ڿ� �ٷ��.
public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ڿ� ���� �޼��� - �빮��, �ҹ���, ���� �ٲٱ�.
        string message = "hello World!";
        Debug.Log(message);

        //[1] �빮��
        Debug.Log(message.ToUpper()); // �빮�ڷ� �ٲٱ�.

        //[2] �ҹ���
        Debug.Log(message.ToLower()); // �ҹ��ڷ� �ٲٱ�.

        //[3] �ٲٱ�
        Debug.Log(message.Replace("hello","�ȳ��ϼ���").Replace("World","����")); //" "��, " "�� �ٲٱ�.
    }
}
