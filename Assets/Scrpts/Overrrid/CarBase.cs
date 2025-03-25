using Bar;
using Override;
using Unity.Android.Gradle;
using UnityEngine;
using static Unity.VisualScripting.Dependencies.Sqlite.SQLite3;

namespace Override
{
    public enum CarType
    {
        전기,
        내연기관
    }

    //부모 클래스 - 추상 클래스(abstract를 붙임 - 인스턴스 생성 불가).
    public abstract class CarBase //CarBase를 상속받는 자식들에게 지정하는 기능(추상메서드)을 강제한다
    {
        

        //부모의 추상 메서드를 실제 코드 구현, 재정의
        public abstract void Left(); //Left() 구현을 강제한다. (추상 메서드), 본문(구현 내용) 없음

        //접근 제한자 public - 자식 클래스와 외부 모든 클래스에 공개, 접근 또는 사용 가능해서 사용할 수 있다.
        public void Back() => Debug.Log("후진한다");

        //접근 제한자 protected - 자식 클래스에서만 접근, 사용 가능
        //접근 제한자 private - (자식 클래스 포함) 외부 모든 클래스에서 접근 불가. private를 선언한 코드블록 안에서만 사용가능.
        protected string LeftMessage { get; private set; } = "좌회전 한다";
    }

    //자식 클래스
    public class Car : CarBase
    {
        //모든 자동차에 공통 속성
        public CarType Style { get; private set; }

        //생성자 - 매개변수를 입력받아 carType 초기화
        public Car(CarType cType)
        {
            //this 키워드를 자식(객체)의 멤버에 접근(생략가능)
            this.Style = cType;
        }

        public void Go() => Debug.Log("달린다");

        //부모의 추상 메서드를 실제 코드 구현 또는 재 정의
        public override void Left()
        {
            //base 키워드를 부모 멤버에 접근
            Debug.Log(LeftMessage); //자식이라 부모의 멤버(LeftMessage)에 접근 가능
        }
    }


    //손자 클래스
    public class HyunDai : Car
    {
        public HyunDai() : this(CarType.내연기관) { }
        public HyunDai(CarType CarType) : base(CarType) { }

    }

    public class Tesla : Car
    {
        public Tesla() : this(CarType.전기) { }

        public Tesla(CarType CarType) : base(CarType) { }
    }
    //sealed(봉인) 키워드를 통해 봉인 클래스 설정 - 더이상 상속이 안된다
    public class Mirea : Car
    {
        public Mirea() : this(CarType.전기) { }
        public Mirea(CarType cayType) : base(cayType) { }

        public new void Go() => Debug.Log("난다"); //Car(자식클래스)의 Go()를 new를 써서 재정의.
    }

    //public class Future : Mirea { }

}
