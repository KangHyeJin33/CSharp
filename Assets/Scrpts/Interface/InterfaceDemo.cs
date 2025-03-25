using UnityEngine;

namespace Inheritance
{
    public class InterfaceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog의 클래스 인스턴스 생성
            Dog dog = new Dog();
            dog.Eat(); // IAnymal 인터페이스 상속받아 구현
            dog.Cry(); // IDog 인터페이스 상속받아 구현


        }
    }
}
