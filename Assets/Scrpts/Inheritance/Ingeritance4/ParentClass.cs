using UnityEngine;

namespace Inheritance04
{
    public class ParentClass : System.Object // ParentClass는 Object를 상속 받고 있다.
    {
        protected void PrintMessage()
        {
            Debug.Log("부모 클래스에서 정의한 내용");
        }
    }
}
/*
public, private, protected (접근 제한자)
protected : 상속받은 자식 클래스 {} 코드 블록 안에서만 접근 가능, 사용 가능.

public : 외부 클래스에서 접근, 사용가능
private : 외부 클래스에서 접근, 사용 불가능
protected : private과 동일, 단, 상속받은 자식 클래스의 코드 블록 안에서는 접근 가능
 */