using UnityEngine;

namespace GenericClass
{
    public class Genericmethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Hello(제네릭) 클래스 인스턴스 생성
            Hello<int> hi = new Hello<int>(); //매개변수가 없는 기본 생성자를 호출
            hi.Say(1234);

            Hello<string> hs = new Hello<string>("안녕하세요"); //매개변수가 있는 기본 생성자를 호출
            hs.Say(hs.GetMessage());
        }
    }
}