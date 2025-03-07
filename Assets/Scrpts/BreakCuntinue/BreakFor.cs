using UnityEngine;

// break문 : 반복문(for, while)에서 { }를 빠져 나오는 명령문.
// 반복문 안에서 break; 문을 만나면 즉시 반복문을 강제 종료한다. 
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 안녕하세요를 3번 출력하는 프로그램.
        // i가 2일 때(i = 2) for문 종료.
        for(int i=0; i < 5; i++)
        {
            //반복 실행문
            Debug.Log("안녕하세요.");

            if(i == 2)
            {
                break;
            }
        }
        // i가 0일 때 -> i < 5 (참) -> 출력 -> i == 2 (거짓) -> if문 실행하지 않음 -> i + 1 = 1 -> i < 5 (참) -> 출력 -> i == 2 (거짓)
        // -> if문 실행하지 않음 -> i(1) + 1 = 2 (참) -> 출력 -> -> i < 5 (참) -> 출력 -> i == 2 (참) -> break; -> for문 종료.

        for (int i = 0; i < 5; i++)
        {
            if (i == 2)
            {
                break;
            }
            //반복 실행문
            Debug.Log("안녕하세요.");

           
        }
        // i가 0일 때 -> i < 5 (참) -> 출력 -> i == 2 (거짓) -> if문 실행하지 않음 -> i + 1 = 1 -> i < 5 (참) -> 출력 -> i == 2 (거짓)
        // -> if문 실행하지 않음 -> i(1) + 1 = 2 (참) -> break; -> for문 종료.
    }
}
