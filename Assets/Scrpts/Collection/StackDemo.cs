using System.Collections;
using UnityEngine;


public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] starkŬ������ ��ü(�ν��Ͻ�, ��ü) ����
        Stack stack = new Stack();

        //[2] ������ �ֱ�(�Է�)
        stack.Push("ù ��°");
        stack.Push("�� ��°");
        stack.Push("�� ��°");

        //[3] ������ ��������(���)
        Debug.Log(stack.Pop()); // �� ��°
        Debug.Log(stack.Pop()); // �� ��°
        Debug.Log(stack.Pop()); // ù ��°

        try
        {
            // ����ִ� ���ÿ��� �����͸� ������
            Debug.Log(stack.Pop());
        }
        catch (System.Exception ex)
        {
            Debug.Log($"�������� : {ex.Message}"); //Underflow
        }
        


    }
}

/*
Stack Ŭ���� : LIFO(Last In First Out) ���·� �����͸� ���� �����ϴ� Ŭ����
LIFO(Last In First Out) : ���Լ���, �������� ���� �����͸� ���� (�Է¹޾�) ���� ������.
- �ֹ��� ���ø� �׾Ƴ��� ������ ������ ����(�ؿ��� ���� �׾Ƴ��� �ʿ� �� ����Ҷ��� �� ������ ���� ������), �칰�� â�� ������ ����

Push() : ���ñ����� ������ �Է�
Pop() : ���ñ������� ������ ���
Overflow : ������ ����á�� �� �߻�
Underflow : ������ ��� ����� �� �߻� 
 */