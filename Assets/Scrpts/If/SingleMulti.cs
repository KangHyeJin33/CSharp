using UnityEngine;

// 실행문 : 단문(1개), 복문(2개 이상).
public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 만약, 조건식이 참이면 {} 안에 있는 실행문을 실행한다.
        /* if(조건식)
         {
            // 실행문1
            // 실행문2
            // ...
         }
         */

        // 단문은 {} 실행문이 1개
        if(1 == 1)
        {
            Debug.Log("단문 1");
        }

        // {}이 생략이 되면, 바로 아래에 있는 1줄만 실행.
        if (1 == 1)
     
            Debug.Log("단문 2");

        if (1 == 1) Debug.Log("단문 3");
        
        // 복문은 실행문이 2개 이상일 때.
        if(1 == 1)
            Debug.Log("복문 1"); // 실행 O.
            Debug.Log("복문 2"); // 실행 X.
    }
}
/*
< 제어문 >
: 프로그램의 흐름(순서)를 정하는 구문.
- 종류
1. 순차문 : 위에서 아래로 순서대로 명령문을 실행. (ex. 선언 -> 출력) 
2. 조건문(if - else, switch) : 조건에 따른 서로 다른 명령문을 실행. 
ex.
if()
{
    
}
3. 반복문
 */