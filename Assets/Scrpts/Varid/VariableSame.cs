using UnityEngine;

public class VariableSame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a, b, c; //�ǹ����� ������ �ܾ�� ����.

        // a, b, c �� �ʱ�ȭ : ���� �� ���� �������� ���� ���¿��� ó������ ���� ������ �� �ʱ�ȭ.
        //a = 10;
        //b = 10;
        //c = 10;
        a = b = c = 10;

        Debug.Log(a + "," + b + "," + c);
        

    }

}
