using UnityEngine;

namespace Inheritance04
{
    public class SubClass : BaseCalss // : (콜론)으로 부모 클래스 지정
    {
        public void PringtDebug()
        {
            base.PringLog(); // 부모(BaseCalss)의 클래스를 가져다 쓸 수있다. base 키워드로 부모 멤버에 접근한다.
        }
    }
}
