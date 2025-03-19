using UnityEngine;

namespace PrivatePulic
{
    public class FieldNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스(객체) 생성
            Person person = new Person(); // PrivatePulic.Person
            person.ShowProfile();

        }
    }
}