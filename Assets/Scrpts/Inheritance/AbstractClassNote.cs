using UnityEngine;


namespace Inheritance10
{
    public class AbstractClassNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //부모는 추상클래스라 객체를 만들지 못한다
            //Squre 클래스의 인스턴스 생성
            Squre squre = new Squre(10); //한 변의 길이가 10인 squre 생성.
            Debug.Log(squre.GetArea()); //면적을 구해서 출력하라

            //Circle 클레스의 인스턴스 생성
            Circle circle = new Circle(10); //반지름이 10인 circle 생성.
            Debug.Log(circle.GetArea());
        }
    }
}