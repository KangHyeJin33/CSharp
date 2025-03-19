using UnityEngine;

namespace Constructor
{

    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car 클래스의 인스턴스(하얀, 파란, 빨간) 생성
            Car whiteCar = new Car(); //흰색 차
            whiteCar.Run();

            //whiteCar 폐차 : GC에서 알아서 소멸

            Car blueCar = new Car("파란"); //흰색 차
            blueCar.Run();

            Car redCar = new Car("빨간"); //흰색 차
            redCar.Run();

        }
    }
}