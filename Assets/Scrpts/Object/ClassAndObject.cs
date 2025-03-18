using UnityEngine;

//개체(Object, 오브젝트) : 설계도인 클래스로 부터 만들어진 하나의 인스턴스(실체, 구성요소)
//[1] ClassCode 이름의 클래스(class)
public class ClassCode
{
    //Empty
}
public class ClassAndObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ClassCode 클래스의 개체(Object, 인스턴스) 만들기
        ClassCode object1 = new ClassCode(); // object1이라는 고유의 개체에 new로 메모리 공간 생성.
        Debug.Log(object1.GetHashCode());

        //[3] ClassCode 클래스의 개체(Object, 인스턴스) 만들기
        ClassCode object2 = new ClassCode(); // object2이라는 고유의 개체에 new로 메모리 공간 생성.
        Debug.Log(object2.GetHashCode());

    }
}
