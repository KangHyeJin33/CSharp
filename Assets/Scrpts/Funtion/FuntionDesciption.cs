using UnityEngine;

public class FuntionDesciption : MonoBehaviour
{
    //[1] Show�޼���(�Լ�)����, ����.
    void Show()
    {
        Debug.Log("Hello World!!!");
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] Show�Լ� ȣ��
        Show();
    }
}
/*
Function(�Լ�) / Method(�޼���)
: �ݺ��ؼ� ����ϵ��� ������� �ϳ� �̻��� ��ɹ����� ������ �ڵ���.

- ���� �Լ� : ���(C#)���� �����ϴ� �Լ�. ����Ƽ���� �����ϴ� �Լ�.
- ����� �Լ� : �����ڰ� ����� �Լ�.

- �Ű������� ���� �Լ�
ex.
void �Լ��̸�() // void : ��ȯ���� ����.
{
    // �ϳ� �̻��� ��ɹ�
    // ...
}
- �Ű������� �ִ� �Լ�
ex.
void �Լ��̸�(�Ű�����)
{
    // �ϳ� �̻��� ��ɹ�
    // ...
}

- ��ȯ���� �ִ� �Լ�
ex.
(������Ÿ��) �Լ��̸�() //ex. int a ()
{
    // �ϳ� �̻��� ��ɹ�
    // ...
    retrun ����(��);
}

// �Լ� ����.
�Է�(�Ű������� ���ؼ� ������ �Է� ����) -> ó��(����)-�Ű������� ���� -> ���.(retrun)

//�Լ�(�޼���)
[1] �Լ� ����(��� ����)
[2] �Լ� ȣ��(��� ���)
 */