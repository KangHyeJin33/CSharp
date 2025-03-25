using UnityEngine;

namespace Inheritance
{
    public interface IAnymal //첫번째 인터페이스(공통 기능)
    {
        void Eat(); //상속 받으면 무조건 쓴다는 강제성을 띔.
    }

    public interface IDog //두번째 인터페이스(공통 기능)
    {
        void Cry();
    }

    public class Cat
    {

    }

    //다른 클래스 상속과 함께 인터페이스의 다중 상속 가능
    public class MyCat : Cat, IAnymal
    {
        public void Eat() { }
    }

    //다른 인터페이스 상속과 함께 인터페이스의 다중 상속 가능
    public class Dog : IAnymal, IDog
    {
        public void Eat()
        {
            Debug.Log("먹다");
        }
        public void Cry()
        {
            Debug.Log("짖다");
        }
        
    }
}
