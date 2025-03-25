using UnityEngine;

namespace Interface
{
    public class InterfaceDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ICar인터페이스 인스턴스 생성
            //ICar car = new ICar(); //추상클래스는 인스턴스를 생성할 수 없고, ICar 멤버 메서드에 구현 부분 생략되어 new로 인스턴스(객체) 생성 불가.

            //ICar인터페이스를 상속받은 Car 클래스의 인스턴스 생성
            Car car = new Car();
            car.Go();
        }
    }
}

/*
Interface(인터페이스)
: 상속받은 자식클래스가 특정 멤버를 반드시 구현되어야 함을 보증.
: 상속받은 자식클래스가 특정 멤버를 강제로 구현하도록 한다.(추상 클래스와 비슷하나 다르다.)
: 인터페이스 이름은 작명 시 맨 앞에 있는 문자는 대문자 'I'를 붙인다.(권장사항)

- 형식
public interface (인터페이스이름)
{
    메서드이름(); //메서드 선언 - 구현 부분 생략
    //...
}
 */