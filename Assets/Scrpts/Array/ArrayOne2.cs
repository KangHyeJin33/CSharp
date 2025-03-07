using UnityEngine;

public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1-1] 1차원 배열 선언, 요소수[방의 갯수]생성, {값} 초기화를 동시.
        //int[] intArray = new int[3] { 1, 2, 3 }; // ex. 0번방에 1의 값 초기화.

        //[1-2] 1차원 배열 선언, 요소수[방의 갯수]생성하면서 크기 생략, {값} 초기화를 동시.
        //int[] intArray = new int[] { 1, 2, 3, 4 }; // 방 4개 생성과 동시에 값 초기화.

        //[1-3] 1차원 배열 선언, {값} 초기화를 동시.
        int[] intArray = { 1, 2, 3, 4 };


        //[4] 배열의 사용
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}번째 방의 값은 : {intArray[i]}");
        }
    }
}
