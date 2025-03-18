using UnityEngine;
using System.Linq;

public class LinqMinMax : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 배열 numbers의 요소중 최대값, 최소값 구하기
        int[] numbers = { 1, 2, 3 };

        //변수 초기화
        int max = 0;
        int min = 0;

        //최대값, 최소값 구하기
        max = numbers.Max(); //최대값
        min = numbers.Min(); //최소값

        Debug.Log($"numbers 배열의 최대값 : {max}, 최소값 {min}");
    }
}
