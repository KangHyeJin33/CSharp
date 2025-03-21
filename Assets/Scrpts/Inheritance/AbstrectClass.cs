using UnityEngine;

namespace Inheritance08
{

    public class AbstrectClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //추상 클래스는 인스턴스(객체)를 만들 수 없음.
            //ParentClass parent = new ParentClass(); // 에러 : 추상형식이라 인스턴스 생성 불가능. ChilldClass에 접근해야 함.

            ChilldClass chilld = new ChilldClass() { Id = 1, Active = true, Name = "홍길동" };
            if(chilld.Active == true)
            {
                Debug.Log($"{chilld.Id} - {chilld.Name}");
            }

        }
    }
}

/*
Abstrect Class(추상 클래스)
: 자신(부모클래스)을 상속 받는 자식클래스에서 강제로 기능을 추가하도록 한다
: 자식 클래스는 부모 클래스가 지정한 기능을 구현하도록 강제한다.
: 추상 클래스는 인스턴스(객체)를 만들 수 없다.
: 추상 클래스는 다른 클래스의 부모 클래스만 사용이 가능하다.

- 추상 클래스 형식
public abstract class (추상클래스이름) //abstract : 인스턴스 생성 불가능.

{

}
 */
