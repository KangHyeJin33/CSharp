using UnityEngine;

namespace Override
{
    // 부모 클래스
    public class Base
    {
        public virtual void Work() => Debug.Log("부모가 일한다"); //virtual : 재정의해서 쓰고 싶으면 붙여서 써라.

    }

    // 자식 클래스
    public class Sub : Base
    {
        //sealed : 상속받지 못하도록 멤버를 봉인한다.(재정의 금지). 메서드에서도 사용가능.
        public override sealed void Work() // 부모클래스를 상속 받고 Work()함수를 재정의 해서 쓰려고 하면 override를 붙이고 사용하라.
        {
            Debug.Log("자식이 일한다");
        }
    }

    //손자 클래스
    public class GrandSub : Sub
    {
        /*public override void Work() //Base를 상속받아 쓰기 때문에 obrride 붙이고 사용.
        {
            Debug.Log("손자가 일한다");
        }*/
        public void Play() => Debug.Log("손자가 논다");
    }
}