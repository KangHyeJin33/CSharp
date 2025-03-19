using UnityEngine;

namespace PrivatePulic
{

    public class ConstructorDescription : MonoBehaviour
    {
        //생성자
        public ConstructorDescription()
        {


        }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ConstructorDescription 인스턴스 생성(cons)
            ConstructorDescription cons = new ConstructorDescription(); //ConstructorDescription() 생성자 메소드 호출.

        }
    }
}
/*
Constructor(생성자)
: 클래스가 사용될 때 가장 먼저 호출되는 메서드.
: 인스턴스(객체)를 생성할 때 호출되는 메서드.
: 클래스 필드의 기본값을 설정하는 역할, 필드 초기화.

- 형식
: Constructor(생성자)의 이름이 클래스 이름과 동일하다.
: public 접근 제한자를 사용한다.
: 반환값도 없고, void도 없다.

: 모든 클래스는 생성자를 가지고 있다.
: 생성자를 만들지 않으면 기본 생성자를 자동으로 만들어준다. (생략이 아님)
: 기본 생성자
public 클래스이름()
{
    
}

ex. class ClassName(ClassName : 클래스이름)
{
    //Constructor(생성자) 정의
    public ClassName() // 클래스이름이 생성자이름이 된다.
    {
        
    }
}

 */
