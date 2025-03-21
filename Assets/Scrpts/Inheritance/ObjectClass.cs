using Inheritance;
using UnityEngine;

public class ObjectClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //static 정적 메서드는 클래스의 인스턴스(객체)를 생성하지 않고 호출한다.
        //static 메서드 호출 방법 : 클래스이름.메서드이름
        ChildClass.Hi();
        ChildClass.Hello();

        //ParentClass 클래스의 인스턴스 생성
        ParentClass parent = new ParentClass();
        Debug.Log(parent.ToString());

        //ChildClass 클래스의 인스턴스 생성
        ChildClass child = new ChildClass();
        Debug.Log(child.ToString());
    }
}
