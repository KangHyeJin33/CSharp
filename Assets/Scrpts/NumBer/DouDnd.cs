using UnityEngine;

public class DouDnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //double pi = 3.141592; // (64 Bit) �Ǽ��� ������ ���� �����ϰ� �ʱ�ȭ.
        //float f = 3.14f; // (32 Bit) �Ǽ��� ������ ���� �����ϰ� �ʱ�ȭ.
        //decimal d = 12.34m; // (128 Bit) �Ǽ��� ������ ���� �����ϰ� �ʱ�ȭ.

        //Debug.Log(pi);
        //Debug.Log(f);
        //Debug.Log(d);

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Debug.Log("double �ּ� �� : " + doubleMin);
        Debug.Log("double �ִ� �� : " + doubleMax);

        float floaMin = float.MinValue;
        float floaMax = float.MaxValue;

        Debug.Log("float �ּ� �� : " + floaMin);
        Debug.Log("float �ּ� �� : " + floaMax);


    }

}
/*
decimal : ����� float�� ����ص� ��Ȯ���� ���� ��, �����ʿ��� ���.


 */