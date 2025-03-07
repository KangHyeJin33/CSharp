using UnityEngine;

// string : 문자(배)열. 문자의 배열.
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string arr = "C#8"; // 문자배열 선언.

        Debug.Log(arr.Length); //문자열의 길이 출력.

        Debug.Log(arr[0]); // 0번방의 데이터 출력. 'C'
        Debug.Log(arr[1]); // 1번방의 데이터 출력. '#'
        Debug.Log(arr[2]); // 2번방의 데이터 출력. '8'
    }
}
