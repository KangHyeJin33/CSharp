using UnityEngine;

// string : ����(��)��. ������ �迭.
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string arr = "C#8"; // ���ڹ迭 ����.

        Debug.Log(arr.Length); //���ڿ��� ���� ���.

        Debug.Log(arr[0]); // 0������ ������ ���. 'C'
        Debug.Log(arr[1]); // 1������ ������ ���. '#'
        Debug.Log(arr[2]); // 2������ ������ ���. '8'
    }
}
