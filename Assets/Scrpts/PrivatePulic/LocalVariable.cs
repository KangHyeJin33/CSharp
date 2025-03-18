using UnityEngine;

namespace PrivatePulic
{
    public class LocalVariable : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start() // private이 맨 앞에 생략되어 있음.
        {
            // i, j(LocalVariable) : 지역 변수. Start()의 { }안에서만 사용하는 로컬변수.
            int i = 1234;
            int j = 4567;

            // 지역변수 사용
            Debug.Log(i + j);
        }
    }
}
/*
Field(필드, 전역변수, 멤버 변수) : 클래스의 부품 역할을 하는 클래스 내부 상태값을 저장하는 그릇(변수).
- 클래스의 속성
- 필드는 액세스 한정자를 지정합니다.
- 필드는 (보통 혹은 대부분) 필드 선언부에서 선언하고 또 초기화 합니다.

< 액세스 한정자 > : 접근 제한자 - 기본 액세스 한정자는 private이다.
- public : 외부에서 접근(사용)이 가능하다. 접근의 제한이 없다.
- private : 해당(현재) 클래스 안에서만 접근이 가능하다.
- protactive : 해당(현재) 클래스 안에서만 접근이 가능하다. 상속받은 자식 클래스에서 접근 가능하다.
- intenal : 해당 프로젝트 내에서 접근이 가능
- protected intenal
 */