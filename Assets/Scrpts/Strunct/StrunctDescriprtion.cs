using UnityEngine;

//Struct(구조체) : 하나의 이름으로 서로 다른 (형식의) 데이터들, 또는 함수들을 묶어서 관리하는 그릇. (데이터 구조). 변수의 확장.
//[1] 구조체 정의(선언, 만들기) : 두 개의 정수를 관리하는 구조체 만들기.
struct Point // int형 x, y 변수를 관리하는 구조체
{
    public int x; // 'public' 키워드를 선언하여 코드 블록 외부(밖)에서 int x 변수를 사용가능하도록 설정.
    public int y;
}


public class StrunctDescriprtion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 구조체 형식의 변수 선언 : Point 구조체 데이터 형식 만들기.
        Point p; // Point(데이터형식)의 변수 p.

        //[3] Point구조체의 x, y 변수에 값을 저장(대입, 할당) 초기화.
        p.x = 100; // Point 구조체의 변수 x 값에 100을 저장.
        p.y = 200; // Point 구조체의 변수 y 값에 200을 저장.

        //[4] 사용
        Debug.Log($"x값은 : {p.x}, y값은 : {p.y} ");


    }
}

/*
ㅇ Varlable(변수) : 데이터를 저장하는 그릇.
ㅇ Array(배열) : 하나의 이름으로 같은 형식의 데이터를 여러개 담는 그릇, 묶음, 변수의 확인.

ㅇ Struct(구조체) : 하나의 이름으로 서로 다른 (형식의) 데이터들, 또는 함수들을 묶어서 관리하는 그릇. (데이터 구조). 변수의 확장.
: 사용자(유저) 정의 데이터 형식.

// 구조체 형식
struct (구조체 이름)
{
    //서로 다른 형식의 데이터들
    //함수들
}

 */
