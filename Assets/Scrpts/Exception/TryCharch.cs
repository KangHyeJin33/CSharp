using UnityEngine;

public class TryCharch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch
        {
            Debug.Log("������ �߻� �߽��ϴ�");
        }

        /*int[] arr = new int[2]; //������ �迭 arr ���� ���� = ��Ҽ� ũ��(�޸�) 2�� ����
        arr[1] = 10;*/
    }
}

/*
����ó��(Exception Handling) : Try-Catch-fially ���� ��� 
����(����)
1. ���� ����
2. ��Ÿ�� ����
3. �˰��� ����

- ����

try
{
    //��ɹ�
    //��ɹ�
    //...
}
catch
{
    //try �ڵ��� �ȿ��ִ� ��ɹ����� ���� �� ����(Exception) �߻� ��� ó���� ����
    // ...
}

 */
