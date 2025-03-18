using UnityEngine;
using Korea.Suwon; // Korea.Suwon;에 묶여있는 클래스를 가져다 사용하겠다.
using Su = Korea.Suwon; // 별칭(Su)을 사용해서 사용하기. Korea.Suwon을 Su 네임스페이스 별칭을 만들어 사용하기.

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 네임스페이스 이름 전체를 지정해서 사용하기
        Korea.Seoul.Car se = new Korea.Seoul.Car(); // se라는 객체 생성
        se.Run(); // 서울 자동차가 달린다

        Korea.Suwon.Car su = new Korea.Suwon.Car();
        su.Run(); // 수원 자동차가 달립니다

        //[2] 네임스페이스 선언부에 using을 선언하여 사용하기
        Car seoul = new Car(); // Car : Suwon의 Car. using Korea.Seoul의 클래스를 사용하면 모호하다고 에러가 뜬다.
        seoul.Run(); //수원 자동차가 달립니다

        //[3] 별칭을 지정해서 사용하기
        Su.Car suwon = new Su.Car();
        suwon.Run();

        //truck 호출하기
        Korea.Seoul.Truck truck = new Korea.Seoul.Truck();
        truck.Run();
    }
}