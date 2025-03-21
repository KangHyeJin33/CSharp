using UnityEngine;

namespace Inheritance11
{
    public class FieldHiddneDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //SubClass 클래스의 인스턴스 생성
            SubClass sub = new SubClass();
            sub.SetWord("필드 숨기기 및 자식클래스에게만 멤버 상속");
            Debug.Log(sub.GetWord());
        }
    }
}
