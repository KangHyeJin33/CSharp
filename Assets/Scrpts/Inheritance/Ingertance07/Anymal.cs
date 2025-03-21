using UnityEngine;

namespace Inheritance07
{ 
    //부모 클래스
    public class Anymal
    {
        public void Eat() => Debug.Log("밥을 먹어요");
    }

    //자식 클래스 : Animal을 부모로 지정
    //sealed 키워드 : Cat클래스를 봉인(sealed) 클래스로 지정, 최종 클래스가 되어 누군가 나를 부모로 지목하지 못하도록(상속받는게) 불가능.
    public sealed class Cat : Anymal //Cat을 상속(부모클래스로)받지 못하도록 막음
    {

    }

    //자식 클래스 : Cat 클래스를 부모로 지정
    /* public class MyCat : Cat
    {
        //sealed(봉인)가 붙은 클래스는 보모로 지정이 불가능.
    } */
}
