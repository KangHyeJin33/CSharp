using UnityEngine;

namespace Interface
{
    //[1] ICar 인터페이스 선언
    public interface ICar
    {
        void Go(); //메세드 선언 또는 정의, {} 구현 부분 생략
    }

    //[2] ICar 인터페이스 상속
    public class Car : ICar //ICar를 상속 받을 땐 ICar에서 정의된 모든 멤버를 구현해야 오류가 없다.
    {
        public void Go()
        {
            Debug.Log("상속한 인터페이스의 정의된 모든 멤버를 반드시 구현해야 한다");
        }
    }
}
