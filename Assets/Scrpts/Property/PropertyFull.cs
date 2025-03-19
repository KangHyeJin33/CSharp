using UnityEngine;

namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스(객체) 생성
            Person person = new Person();

            //[2] 메서드 이용하여 name값 저장 및 사용하기
            person.SetName("홍길동");
            Debug.Log(person.GetName());

            //[3] property(속성)을 이용하여 private한 필드(name)값 저장 및 사용
            //Name 속성의 set 기능 이용
            person.Name = "백두산"; //백두산 : value 값
            //Name 속성의 get 기능 이용
            Debug.Log(person.Name); //Name 필드 값 : return 값
        }
    }
}
