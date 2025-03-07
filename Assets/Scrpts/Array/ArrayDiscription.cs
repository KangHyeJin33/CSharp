using UnityEngine;

// Varlable(변수) : 프로그램(데이터를 다루는 기술)에서 사용하는 데이터를 저장해 놓는 그릇.
// Array(배열) : 하나의 이름으로 같은 데이터 형식을 여러개 보관 놓는 그릇.
// 선언 : 데이터타입[] 변수명(이름);
// 크기 기정 : 변수명(이름) = new 데이터타입[크기]
public class ArrayDiscription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;

        //[1] 배열 선언.
        int[] numbers; //int형 배열number의 하나의 방 마다의 크기는 4Bit.

        //[2] 배열의 요소수 생성 - 그릇 갯수 지정(배열의 크기).
        numbers = new int[n]; // 0번 방 ~ 9번 방.(10개의 방). 0 ~ n-1.

        //[3] 배열의 저장 또는 초기화(대입).
        numbers[0] = 3840; // 0번 방.(맨 처음에 있는)
        numbers[1] = 2160;

        //[4] 배열의 사용
        Debug.Log(numbers[0] * numbers[1] * numbers[2]);


    }
}
