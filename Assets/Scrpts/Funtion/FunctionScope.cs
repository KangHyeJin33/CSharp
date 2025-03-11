using UnityEngine;

// 전역 변수, 지역 변수
public class FunctionScope : MonoBehaviour
{
    string message = "전역 변수"; // 필드. 멤버 변수. 전역변수.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string Message = "지역 변수"; // 지역변수.    

        ShowMessage();
        PrintMessage();

        Debug.Log(message);
    }

    // message를 출력하는 함수.
    void ShowMessage()
    {
        string msg = "지역 변수"; //= string massege = "지역 변수";
        Debug.Log(msg); //(msg) = (massege)
    }

    void PrintMessage()
    {
        //Debug.Log(msg); // 오류 : 'PrintMessage()'가 'msg'를 모른다. 'ShowMessage()'의 코드블록(지역)에서만 유효하기 때문에.
        Debug.Log(message);
    }
}
