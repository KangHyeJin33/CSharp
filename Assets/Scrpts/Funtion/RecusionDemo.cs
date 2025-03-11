using UnityEngine;

// ���丮�� ���ϴ� �˰���(4!)
public class RecusionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Hi();
        // 4! = 1 * 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);

        //For Fatorial
        Debug.Log(FactorialFor(4));

    }

    //For�� �̿� Fatorial �� ���ϱ�
    int Factorial(int n)
    {
        int result = 1; // ���ϱ� ���� ���� 1���� ����.

        for(int i = 1; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }
    // ����Լ� �̿� Factorial�� ���ϱ�.
    int FactorialFor(int n)
    {
        if(n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }


}

/*
����Լ� : �Լ��� �ڽ��� �ڵ� ��� �ȿ��� �ڱ� �ڽ��� �ٽ� ȣ��(��� ȣ��)�ϴ� �Լ�.
ex.
void Hi() //�Լ��� �ڽ��� �ڵ� ��� �ȿ���
{
    Hi(); //�ڱ� �ڽ��� �ٽ� ȣ��(��� ȣ��)�ϴ�. ���� ����.
}
- ����Լ��� �Ű����� : �Ű������� ����, ������ �ȴ�.
- ����Լ� �ڵ� ��� �ȿ��� ����Լ��� ���� �� �� �ִ� ������ �ʿ��ϴ�.(���ѷ��� ����)
 */