using System.Collections.Generic;
using UnityEngine;

namespace GenericClass
{
    public class Student
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    //제네릭 클래스(List<T>)
    //: 형식 매개변수 T에 지정한 형식
    public class GenericCollection : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "홍길동", Number = 1},
                new Student { Name = "백두산", Number = 2},
                new Student { Name = "장길산", Number = 3}
            };

            Student student = new Student() { Name = "김단비", Number = 4 }; 
            students.Add(student); //객체를 생성해서 전학생을 List에 포함시킴.

            foreach (var s in students)
            {
                Debug.Log($"{s.Name} - {s.Number}");
            }
        }
    }
}
