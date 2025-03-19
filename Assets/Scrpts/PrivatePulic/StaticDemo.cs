using UnityEngine;


namespace PrivatePulic
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //PublicPrivate 클래스의 정적 필드, 정적 메서드 사용
            PublicPrivate.name = "홍길동"; //객체를 만들지 않고 '클래스이름.정적필드이름', '클래스이름.정적메서드이름'으로 사용
            //Debug.Log(PublicPrivate.name);
            string sName = PublicPrivate.GetName();
            Debug.Log(sName);
            //PublicPrivate.age = 22; (x) //정적 멤버에 접근 안됨.

            //PublicPrivate의 객체 생성
            PublicPrivate publicPrivate = new PublicPrivate();
            //PublicPrivate.ate = 22; (x) //개체로 접근이 안됨.
            publicPrivate.SetAge(22);
            //int myAge = Set publicPrivate
        }
    }
}
