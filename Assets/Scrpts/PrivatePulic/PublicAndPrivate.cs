using UnityEngine;


namespace PrivatePulic
{
    public class PublicAndPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] Car 클래스의 객체(인스턴스) 생성
            Car myCar = new Car();

            //[2] Car 클래스의 객체를 통해 public한 필드에 접근해서 사용
            myCar.name = "홍길동";
            Debug.Log(myCar.name);

            //[3] Car 클래스의 객체를 통해 private 필드에 접근해서 사용 (x)
            //myCar.age = 21; // 액세스 한정자로 접근하지 못함.
            //myCar.address = "수원"; // 액세스 한정자로 접근하지 못함

            //[4] Car 클래스의 객체를 통해 public 메서드에 접근해서 사용
            myCar.Hi();

            //[5] Car 클래스의 객체를 통해 private 메서드에 접근해서 사용 (x)
            //myCar.Bye(); // private(액세스 한정자)로 접근하지 못함
        }
    }
}
