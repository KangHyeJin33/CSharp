using UnityEngine;

namespace Inheritance08
{
    public abstract class ParentClass
    {
        public int Id { get; set; }
        public bool Active { get; set; }
    }

    //자식 클래스 : 추상 클래스를 상속 받는다
    public class ChilldClass : ParentClass
    {
        public string Name { get; set;}
    }
}
