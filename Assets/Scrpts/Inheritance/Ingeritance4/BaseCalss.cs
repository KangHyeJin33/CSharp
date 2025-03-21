using UnityEngine;

namespace Inheritance04
{
    public class BaseCalss : System.Object // 모든 클래스는 Object 클래스부터 상속 받는다.
    {
        protected void PringLog()
        {
            Debug.Log("부모 클래스의 메서드에서 호출");
        }
    }
}
