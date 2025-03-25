using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace GenericClass
{
    public class Person //이름 속성을 가지고 있는 클래스(person)
    {
        //속성
        public string Name { get; set; }
    }

    public class CollectionInitializers : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "홍길동"},
                new Person { Name = "백두산"},
                new Person { Name = "장길산"},
            };

            foreach (var p in people)
            {
                Debug.Log(p.Name);
            }
        }
    }
}
