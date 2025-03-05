using UnityEngine;

// 조건문(if - else, switch) : 조건에 따른 서로 다른 명령문을 실행.
// 만약, score가 60점 이상이면 "합격"이라고 출력.
// score 61점.
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61; // 정수형 변수로 score의 값을 61로 선언 및 초기화.

        if (score >= 60) // 만약, score가 60점 이상 또는 크거나 같을 때, 조건문이 참이면 블록 안에 있는 실행문 실행.
        {
            Debug.Log($"score : {score}점으로 '합격' 입니다."); // "score : 61점으로 '합격' 입니다."출력
        }
    }
} 
/*
< 제어문 >
: 프로그램의 흐름(순서)를 정하는 구문.
- 종류
1. 순차문 : 위에서 아래로 순서대로 명령문을 실행. (ex. 선언 -> 출력) 
2. 조건문(if - else, switch) : 조건에 따른 서로 다른 명령문을 실행. 
* if문 - 조건식이 참 일때만 실행문이 실행된다.
       - 조건식이 거짓이면 실행문을 실행하지 않는다.
ex.
if(조건식) // 만약, 조건식이 참이면 코드블럭("{}")안에 있는 실행문을 실행하라.
{
  //실행문 1
  //실행문 2
  // ...
}

if(bool) // 만약, 조건식이 참이면 코드블럭("{}")안에 있는 실행문을 실행하라.
{
  //실행문 1
  //실행문 2
  // ...
}

3. 반복문
 */