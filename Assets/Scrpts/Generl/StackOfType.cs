using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Generic Class(제네릭 클래스) : 형식 매개 변수 T(데이터 Type)에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
// Cup<T> : 컵어브티, 전용 컵.
public class StackOfType : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack<T> 클래스 인스턴스(객체, 개체) 생성
        Stack<string> stack = new Stack<string>(); // <string> 전용 Stack 클래스의 인스턴스를 생성 : 문자열만 입력

        //[2] 데이터 넣기 : 문자열만 입력 가능
        stack.Push("10"); // 주의! 숫자 10이아닌 문자 10임.
        stack.Push("TEN");

        //[3] 데이터 꺼내기
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());


    }
}
