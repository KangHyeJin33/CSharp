using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 선언문.
        int x = 1;

        // switch(조건) -> Data(데이터)값을 판별.
        switch (x)
        {
            case 1:
                Debug.Log($"{x}(은)는 1 입니다."); //[2] 실행문 2
                break;
            case 2:
                Debug.Log($"{x}(은)는 2 입니다.");//[3] 실행문 3
                break;
        }
        //[4] 실행문 4
        Debug.Log("프로그램 종료.");

        //int x = 2;
        //[실행문 1] -> [실행문 3] -> [실행문 4]
        //int x = 1;
        //[실행문 1] -> [실행문 2] -> [실행문 4]



    }
}
/*
 < switch 문 > : 조건문 또는 선택문.

switch(조건) -> Data(데이터)값을 판별.
{
    case 1번:
       // 실행문 1 실행.
       break;

    case 2번:
       // 실행문 2 실행.
       break;

    case 3번:
       // 실행문 3 실행.
       break;

    defalt: // 모든 case가 아니면
       // 실행문 4 실행.
       break;
}


if(조건식) -> 조건식을 참, 거짓 판별.
{
    실행문 1
}
else
{
    실행문 2
}



 */ 
 