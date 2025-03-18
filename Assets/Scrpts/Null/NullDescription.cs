using UnityEngine;

public class NullDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //값 형식
        //int i = 0; // null로 초기화 불가능.

        //참조 형식
        //string s = null; //null 참조. 아무것도 가르키지 않음.
        //s = "안녕하세요"; //참조 시작

        //string empty = ""; //null이 아님.


    }
}

/*
Null(NULL, null) : 아무것도 없는 상태, 아무것도 없음을 의미하는 리터널.
- 인스턴스(객체, 개체)가 아무것도 참조(가리킴)하지 않음. null 참조라고 불린다.

(값 형식) (변수) 1234
(참조 형식) (변수) --------> "안녕하세요"
(참조 형식) (변수) (아무것도없음-null)
: 참조형 변수에 아무런 값도 설명하지 않음, null 참조.
string ""(빈 값 - 화살표가 없음, empt - 화살표가 있음)과 null은 다름


 */