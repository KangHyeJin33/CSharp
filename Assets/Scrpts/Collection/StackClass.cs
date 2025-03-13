using System.Collections; //System의 Collections 네임스페이스를 사용한다
using UnityEngine;

// Collections : Stack, Queue, ArrayList, Hashtable. - Class
public class StackClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Stack 클래스의 인스턴스(객체) 생성으로 메소드 사용가능
        Stack st = new Stack();

        //스택에 데이터 넣기 : Push(메소드)
        st.Push("First"); //스택이라는 컬렉션에 값(First) 저장
        st.Push("Second");

        //스택에서 데이터 꺼내기 : Pop(메소드)
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());
    }
}
