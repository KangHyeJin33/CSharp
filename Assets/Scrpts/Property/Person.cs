using UnityEngine;

namespace Property
{
    public class Person
    {
        //필드, 멤버변수
        private string name;

        //public한 property(속성)을 이용하여 private한 필드(name - private string name;)에 접근
        public string Name
        { 
            get { return name; }//필드의 name을 얻어와서 리턴시킨다.
            set { name = value; } //필드의 값을 저장한다.
        }

        //public한 메서드를 이용하여 private한 필드(name)에 접근
        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }


    }
}
