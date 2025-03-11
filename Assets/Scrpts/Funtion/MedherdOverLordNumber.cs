using UnityEngine;


// MethodOverlord(메서드 오버로드, 함수 다중 정의)
// 뜻 : 하나의 이름으로(동일한 이름) 메서드를 매개 변수를 달리해서 여러개 생성하는것.
public class MedherdOverLordNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintNumber(1234); // 정수형
        PrintNumber(1234L); // long형의 정수형
        PrintNumber(1234F); // float형의 실수형
    }

    // 매개변수로 숫자를 입력받아 출력하는 함수(PrintNumber).
    // int 타입의 정수를 매개변수로 입력받아 출력.(void PrintNumber(int number))
    void PrintNumber(int number)
    {
        Debug.Log($"Int32 : {number}");
    }
    //long 타입의 정수를 매개변수로 입력받아 출력.
    void PrintNumber(long number)
    {
        Debug.Log($"Int64 : {number}");
    }
    //float 타입의 실수를 매개변수로 입력받아 출력.
    void PrintNumber(float number)
    {
        Debug.Log($"실수형 : {number}");
    }
}
