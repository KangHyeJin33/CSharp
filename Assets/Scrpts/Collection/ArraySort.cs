using UnityEngine;

// sort(정렬) : 오름차순(1, 2, 3, 4, 5, 6 ...) - 기본, 내림차순(6, 5, 4, 3, 2, 1 ...)
public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = { 3, 2, 1, 4, 5 }; // 정렬안된 데이터

        for(int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("========================================");

        //Sort - 오름차순 정렬
        System.Array.Sort(arr); //클래스이름.함수이름

        foreach (var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("========================================");

        //Revers  - 현재 배열의 역순(맨 앞값을 맨 뒤로) 정렬
        System.Array.Reverse(arr);

        foreach (var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("========================================");
    }
}
