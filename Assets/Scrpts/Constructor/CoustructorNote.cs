using UnityEngine;

namespace Constructor
{
    public class CoustructorNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스 생성
            //[1] 매개변수가 없는 기본 생성자 호출
            Person saram1 = new Person(); //기본형 생성자 호출. 이름이 saram1에 저장됨.
            Debug.Log(saram1.GetName()); //이름을 가져다 출력한다.

            Person saram2 = new Person(); //기본형 생성자 호출. 이름이 saram2에 저장됨.
            Debug.Log(saram2.GetName()); //이름을 가져다 출력한다.

            //[2] 매개변수가 있는 생성자 호출
            Person person1 = new Person("백두산");
            Debug.Log(person1.GetName());

            Person person2 = new Person("장길산");
            Debug.Log(person2.GetName());

        }
    }
}
