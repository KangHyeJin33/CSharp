using UnityEngine;

// 순차문 : 위에서 아래로 순서대로 명령문을 실행. (ex. 선언 -> 출력)
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 100; // 국어 점수 저장하는 변수 선언.
        int eng = 90; // 영어 점수 저장하는 변수 선언.

        int total = 0; // 총점.
        double avg = 0.0; // 평균 점수.

        //[2] 변수에 값 대입.
        total = kor + eng; // 총점 구하기.
        avg = total / 2.0; //평균 구하기.

        //[3] 변수 사용.
        Debug.Log($"총점 : {total}");
        Debug.Log($"평균 : {avg}");

    }
}
/*
< 제어문 >
: 프로그램의 흐름(순서)를 정하는 구문.
- 종류
1. 순차문 : 위에서 아래로 순서대로 명령문을 실행. (ex. 선언 -> 출력) 
2. 조건문 : 
3. 반복문
 */