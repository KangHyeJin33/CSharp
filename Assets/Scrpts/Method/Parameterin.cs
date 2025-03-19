using System.Globalization;
using UnityEngine;

namespace Methood
{
    //[1] 값 전달 방법 (int num)

    public class Parameterin : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int num = 10;
            Debug.Log($"[1] : {num}");

            PrintNumber(num);

            Debug.Log($"[3] : {num}");
        }
        
        //매개변수로 전달(입력)받은 정수(num)를 출력하는 함수
        void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2] : {num}");
        }
    }
}

/*
매개변수 ( ) - 값이 전달 되는 방법을 구분
[1] 값 전달 방법 :  (int num)
[2] 참조 전달 방법 : (ref int num) // ref : reference(레퍼런스).
[3] 반환형 전달 방법 : (out int num)
[4] 가변형 번달 방법 : (params int[] numbers)

 */
