using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 제네릭 사용하지않을 경우 (사용 전)
        Stack st1 = new Stack(); // Stack st1 : st1이라는 객체 생성
        st1.Push(1234); //1234 : 오브젝트로 들어가서 박싱.
        int number1 = (int)st1.Pop(); //언박싱 혹은 캐스팅, 명시적 형 변환. (타입 변환)

        Debug.Log(number1);

        //[2] 제네릭 사용 시
        Stack<int> st2 = new Stack<int>();
        st2.Push(5678);
        int number2 = st2.Pop(); //타입변환없이 바로 변환

        Debug.Log(number2);

        //[1] :

        //[3] 제네릭 장점 : 형식의 안정성(버그가 발생할 가능성 낮음), 성능 향상
        // 형식의 안정성
        Stack o = new Stack();
        o.Push(1234);
        o.Push("Hello");
        Debug.Log(o.Pop());
        Debug.Log(o.Pop());

        Stack<int> i = new Stack<int>();
        i.Push(2345);
        //i.Push("d"); //int만 처리 가능
        Debug.Log(i.Pop()); // 꺼내기 전 int(정수)형 타입인걸 알고있음.

        // 최적화(성능)
        Stack stack = new Stack();
        stack.Push(1234); // 1234(값형). 오브젝트(참조형) 타입으로 저장. 박싱(포장).
        int iStack = (int)stack.Pop(); // 오브젝트 -> 값형 : 언박싱.
        Debug.Log(iStack);



    }
}
