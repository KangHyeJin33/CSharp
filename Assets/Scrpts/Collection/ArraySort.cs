using UnityEngine;

// sort(����) : ��������(1, 2, 3, 4, 5, 6 ...) - �⺻, ��������(6, 5, 4, 3, 2, 1 ...)
public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = { 3, 2, 1, 4, 5 }; // ���ľȵ� ������

        for(int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("========================================");

        //Sort - �������� ����
        System.Array.Sort(arr); //Ŭ�����̸�.�Լ��̸�

        foreach (var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("========================================");

        //Revers  - ���� �迭�� ����(�� �հ��� �� �ڷ�) ����
        System.Array.Reverse(arr);

        foreach (var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("========================================");
    }
}
