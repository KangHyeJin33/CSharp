using UnityEngine;

namespace Methood
{
    public class RectangleClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Rectangle 클래스의 인스턴스 생성
            Rectangle rect = new Rectangle();
            Debug.Log(rect.GetName());
        }
    }
}
/*
[1] 메서드 구성 - 문법
public(private) static(x) void(반환 타입이 없다, int, string으로 대신할 수 있음) 메서드이름(매개변수1, 매개변수2, ...)
{
    //메서드의 실행문
}

[2] 메서드 이름 - 스타일
동사 + 이름 : 
()를 가져온다 => GetName(이름을 가져옴), GetHP(체력값을 가져옴)
()를 저장한다 => SetName("홍길동");

 */