using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Add(5, 3);
        int result = Add(5, 3);
        Debug.Log($"3 + 5 = {result}"); // [1]
        //Debug.Log(result); [2]

        Sub(5, 3);
        Mul(5, 3);
        Dev(5, 3);
        Rem(5, 3);

    }

    /* void Add(int a, int b)
    {
        Debug.Log($"{a} + {b} = {a + b}" );
    }*/
    int Add(int a, int b)
    {
        return a + b;
    }

    /*
    [1]*/ void Sub(int a, int b)
    {
        Debug.Log($"{a} - {b} = {a - b}" );
    }
    /*[2] void Sub(int a, int b) => x - y; // ȭ��ǥ �Լ� �Ǵ� ���ٽ� �Ǵ� ����� �Լ���� �Ѵ�.
    */

    void Mul(int a, int b)
    {
        Debug.Log($"{a} * {b} = {a * b}");
    }

    void Dev(int a, int b)
    {
        Debug.Log($"{a} / {b} = {a / b}");
    }

    void Rem(int a, int b)
    {
        Debug.Log($"{a} % {b} = {a % b}");
    }
}

/*
[Q]
��Ģ����( +, -, *, /, % )�� ���ϴ� �Լ� �����. 4��. ������( % ).
�� ���� ������ �Է� �޾�  +, -, *, /, % ����Ͽ� ������� ��ȯ�ϴ� �Լ� �����.
Add, Subtract, Multply, Devide, Remainder.

�Է°� : 5, 3

[OutPut]

 */