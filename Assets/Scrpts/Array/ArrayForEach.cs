using UnityEngine;

//ForEach : �迭�� ����� ������ ������� ���(ó��(0)���� ��(n)����) �����ͼ� ���.
public class ArrayForEach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�迭 ��ҵ��� ���� ��� �����ͼ� ������ ���ϴ� ���α׷��� ����.
        float[] arr = { 10.5f, 20.1f, 30.3f };
        float sum = 0f; // 'f'�� ������ float������ double�� ���°� �ٲ�.

        /*for(int i=0; i < 3; i++)
        {
            sum = sum + arr[i];
            
        }*/

        foreach(float f in arr)
        {
            // �ݺ����๮.
            sum = sum + f;
            
        }

        Debug.Log($"������ {sum}");

    }
}

/*
ForEach : �迭�� ����� ������ ������� ���(ó��(0)���� ��(n)����) �����ͼ� ���.
�迭�� �����͸� ó������ ������ �������� ���̻� ������ �����Ͱ� ������ �ݺ��� ����.

foreach(�迭�ǵ�����Ÿ�� �����̸� in �迭�����̸�)
{
    //�ݺ����๮
}

 */
