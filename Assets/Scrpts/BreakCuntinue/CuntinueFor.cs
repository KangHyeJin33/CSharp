using UnityEngine;

// continue���� �ݺ������� continue���� ������, continue�� �Ʒ��� �ִ� ���๮�� �������� �ʰ�,
// ���� �ݺ����� ���ǽ��� �Ǻ��� ���� �ݺ��� ����.
public class CuntinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1���� 5���� Ȧ���� ����ϴ� ���α׷�.
        /*for(int i = 1; i <=5; i++)
        {
            if(i % 2 != 0) // i�� 2�� ������ �� �������� 0�� �ƴϸ� (Ȧ�� �Ǻ���)
            Debug.Log(i);
        }*/

        //¦�� ���� Ȧ���� ���.
        for (int i = 1; i <= 5; i++)
        {
            if (i % 2 == 0) // i�� 2�� ������ �� �������� 0�� �ƴϸ� (¦�� �Ǻ���)
            {
                continue; //�Ʒ� Debug.Log(i);�� ������ �ش� ���๮�� ���������ʰ� ���ǽ�(for��)���� ����. ���� �ݺ� �������� �ݺ����� �����ϰ� ���� �ݺ������� �̵��϶�.
            }
                Debug.Log(i); // i�� ����Ѵ�.
        }
       

    }
}
