using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Number = 3;
        string Name = "Ȧ��";
        Debug.Log($"�ش� ���ڴ� {Number}" + $"��(��) {Name} �Դϴ�.");
    }


}
/*
[Q]
3, Ȧ���� �������� �ϰ� �����Ѵ�.
���ڿ� �������� �̿��ؼ� ����� ������ ���.

[OutPut]
3��(��) Ȧ���Դϴ�.

 */
