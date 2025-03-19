using UnityEngine;

namespace Constructor
{

    public class ConstructorOverlord : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ConstructorLorg 클래스 인스턴스 생성
            ConstructorLorg log1 = new ConstructorLorg(); //기본생성자로 인스턴스 생성
            ConstructorLorg log2 = new ConstructorLorg("홍길동"); //매개변수가 있는 생성자 호출하고 생성
            ConstructorLorg log3 = new ConstructorLorg("백두산");
        }
    }
}
