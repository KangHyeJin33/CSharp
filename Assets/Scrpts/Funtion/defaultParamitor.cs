using UnityEngine;

// DefaultParamitor(기본 매개변수, 선택적 매개변수) : 매개변수 선언과 동시에 초기화도 한다.
// 선택적 매개변수는 함수 호출 시 생략 가능하다. 생략 시 초기화 한 값이 사용되어진다.
public class defaultParamitor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {/*
        //매개변수가 없는 함수 호출.
        PrintMessage();

        //매개변수가 있는 함수 호출.
        string error = "디버그";
        PrintError(error);

        //반환값이 있는 함수 호출
        string errorlog = PrintLog();
        Debug.Log(errorlog);*/

        PrintError("디버그", 4);
        PrintError("디버그"); // 선택적 매개변수로 'PrintError("디버그", 1);'로 가능.
    }

    // Message를 출력하는 함수.
    void PrintMessage()
    {
        string message = "디버그";
        Debug.Log(message);
    }
    void PrintError(string message, int level = 1) // 레벨의 매개변수 받는게 없으면 (int level = 1) 레벨 초기값(1) 설정.
    {
        Debug.Log($"에러 : {message}, 레벨 :{level}"); //유저가 n레벨일 때, 에러 메세지 발생.
    }

    string PrintLog()
    {
        string log = "디버그 로그";
        return log;
    }
}
