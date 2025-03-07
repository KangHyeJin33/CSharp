using UnityEngine;


// 안녕하세요를 3번 출력하는 프로그램.
public class WhileDecription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i=0; i < 3; i++) [1] 반복횟수 : 3 - 0 = 3
        //for(int i=1; i < 4; i++) [2] 반복횟수 : 4 - 1
        //for(int i=1; i <=3; i++) [3] 반복횟수 : 3 - 1 + 1

        //for(초기식; 조건식; 증감식)
        /*for(int i=0; i< 3; i++)
        {
            // 반복실행문
            Debug.Log("안녕하세요");
        }*/

        //[1] 초기식
        int i = 0;

        while(i < 3) //[2]조건식
        {
            //반복 실행문.
            Debug.Log("안녕하세요.");

            //증감식
            i++; //왜 증감식이 마지막에 있느냐? -> 반복문이 끝나고 증감식을 하는데, 여기서 끝나거나 끝나기 직전에 반복 하기 전, while문의 조건식(i < 3) 판별 역할.(코드해석 편리)
        }
        // int i=0; -> 조건식 판별(i : 0) 참 -> 출력 -> 증감식 (i : 1) -> 조건식 판별(i : 1) 참 -> 출력.
        // 증감식 (i : 2) 참 -> 출력 -> 증감식 (i : 3) -> 조건식 판별 (i : 3) 거짓 -> while문 종료.

    }
}

/*
< While 문 > : 반복문.
- 조건식이 true면 반복문을 실행한다.
- 조건식이 false면 while문을 종료한다.

while(조건식) // while문은 조건식(true, false)을 판단.
{
    //반복 실행문.

    //조건식에 들어가는 변수 증감식.
}

조건식 판별(참) -> 반복문 실행 -> 조건식 판별(참) -> 반복문 실행 -> ... (조건식이 참이면 무한반복) 
조건식 판별(참) -> 반복문 실행 -> 조건식 판별(참) -> 반복문 실행 -> 조건식 판별(거짓) -> while 종료.

 */