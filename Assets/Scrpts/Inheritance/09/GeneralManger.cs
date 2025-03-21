using UnityEngine;

namespace Inheritance09
{
    //추상 클래스 : 자신을 상속 받는 자식 클래스에서 지정한 기능(메서드)을 강제로 구현 하도록 한다.
    //추상 메서드 : 지정한 기능(메서드)
    //public abstract void (추상메서드이름)();
    public abstract class GeneralManger //GeneralManger는 개체를 만들수없다.
    {
        // 함수(메서드)를 추상 메서드로(abstract) 만들기
        // 추상메서드 : 메서드 구현 부분(코드블록, 본문)을 생략. 선언만.
        public abstract void SayTalk(); // 실제 호출 x
       
    }

    //추상 클래스(GeneralManger)을 상속 받는 자식 클래스
    public class Person : GeneralManger //Person 클래스를 만들고 GeneralManger를 상속 받는다.
    {
        //상속 받은 추상 메서드 구현 부분
        //public 'override' void (추상메서드이름)()
        public override void SayTalk()
        {
            Debug.Log("상속 받은 추상 메서드를 구현한다"); // 실제 호출 o
        }
    }
}
