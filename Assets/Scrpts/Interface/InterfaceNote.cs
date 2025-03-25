using UnityEngine;

namespace Inheritance
{
    public class InterfaceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //HDCar 클래스 인스턴스 생성
            HdCar goodCar = new HdCar(new Good()); //자식클래스의 객체를 받아올 수 있다.
            goodCar.Run();

            HdCar badCar = new HdCar(new Bad());
            badCar.Run(); // 자식클래스의 인스턴스를 저장한다.

        }
    }
}
