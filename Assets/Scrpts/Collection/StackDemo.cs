using System.Collections;
using UnityEngine;


public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] stark클래스의 객체(인스턴스, 개체) 생성
        Stack stack = new Stack();

        //[2] 데이터 넣기(입력)
        stack.Push("첫 번째");
        stack.Push("두 번째");
        stack.Push("세 번째");

        //[3] 데이터 꺼내오기(출력)
        Debug.Log(stack.Pop()); // 세 번째
        Debug.Log(stack.Pop()); // 두 번째
        Debug.Log(stack.Pop()); // 첫 번째

        try
        {
            // 비어있는 스택에서 데이터를 꺼내라
            Debug.Log(stack.Pop());
        }
        catch (System.Exception ex)
        {
            Debug.Log($"에러내용 : {ex.Message}"); //Underflow
        }
        


    }
}

/*
Stack 클래스 : LIFO(Last In First Out) 형태로 데이터를 저장 관리하는 클래스
LIFO(Last In First Out) : 후입선출, 마지막에 넣은 데이터를 가장 (입력받아) 먼저 꺼낸다.
- 주방의 접시를 쌓아놓는 형태의 데이터 구조(밑에서 부터 쌓아놓고 필요 시 사용할때는 맨 위에서 부터 꺼낸다), 우물형 창고 데이터 구조

Push() : 스택구조에 데이터 입력
Pop() : 스택구조에서 데이터 출력
Overflow : 스택이 가득찼을 때 발생
Underflow : 스택이 모두 비었을 때 발생 
 */