using UnityEngine;

// 인스턴스 메서드 만들기
public class MyMath // 클래스 만들기
{
    //[1] 두 수의 합을 구하는 메서드(함수) 선언 또는 정의
    public void Sum(int x, int y) // 인스턴스 메서드(함수) 만들기
    {
        int sum = x + y;
        Debug.Log($"두 수의 합은(합계) : {sum}");
    }
}
public class ClassMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] MyMath 클래스의 인스턴스(객체) 생성
        MyMath myMath = new MyMath();

        //[2] '개체이름.인스턴스메서드이름' 형태로 호출
        myMath.Sum(3, 5);
    }
}
