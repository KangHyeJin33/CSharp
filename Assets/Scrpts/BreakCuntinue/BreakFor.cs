using UnityEngine;

// break�� : �ݺ���(for, while)���� { }�� ���� ������ ��ɹ�.
// �ݺ��� �ȿ��� break; ���� ������ ��� �ݺ����� ���� �����Ѵ�. 
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // �ȳ��ϼ��並 3�� ����ϴ� ���α׷�.
        // i�� 2�� ��(i = 2) for�� ����.
        for(int i=0; i < 5; i++)
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���.");

            if(i == 2)
            {
                break;
            }
        }
        // i�� 0�� �� -> i < 5 (��) -> ��� -> i == 2 (����) -> if�� �������� ���� -> i + 1 = 1 -> i < 5 (��) -> ��� -> i == 2 (����)
        // -> if�� �������� ���� -> i(1) + 1 = 2 (��) -> ��� -> -> i < 5 (��) -> ��� -> i == 2 (��) -> break; -> for�� ����.

        for (int i = 0; i < 5; i++)
        {
            if (i == 2)
            {
                break;
            }
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���.");

           
        }
        // i�� 0�� �� -> i < 5 (��) -> ��� -> i == 2 (����) -> if�� �������� ���� -> i + 1 = 1 -> i < 5 (��) -> ��� -> i == 2 (����)
        // -> if�� �������� ���� -> i(1) + 1 = 2 (��) -> break; -> for�� ����.
    }
}
