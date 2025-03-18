using UnityEngine;

public class ClassTwo : MonoBehaviour
{
    //정적(static) 멤버 메서드 : 호출 - 클래스이름.메서드이름
    public static void Hi()
    {
        Debug.Log("반갑습니다");
    }

    //인스턴스(instance) 멤버 메서드. static 없는 메서드.
    public void Hello()
    {
        Debug.Log("또 만나요");
    }
}
