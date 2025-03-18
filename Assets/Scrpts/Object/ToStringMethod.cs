using UnityEngine;

public class My
{
    //Empty(비어있음)
}

public class Your
{
    public override string ToString() //ToString() 를 다시 정의하여 새로운 문자열 출력
    {
        return "새로운 반환 문자열 지정";
    }
}
public class ToStringMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // My 클래스의 인스턴스 생성
        My my = new My();
        //인스턴스(개체)를 출력하라 -> 클래스 이름 출력된다. 
        Debug.Log(my);

        //Your 클래스의 인스턴스 생성
        Your your = new Your();

        Debug.Log(your);
    }
}
