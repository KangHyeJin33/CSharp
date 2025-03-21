using UnityEngine;

namespace Inheritance
{

    public class ChildClass : ParentClass // ChildClass(자식)는 ParentClass(부모)를 상속받는다.
    {
        public static void Hello() //정적 메소드
        {
            Debug.Log("반갑습니다");
        }
    }
}
