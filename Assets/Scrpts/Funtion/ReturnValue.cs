using UnityEngine;

// 반환값이 있는 함수 만들고 호출하기
public class ReturnValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 반환값이 있는 함수 호출(사용)
        // 반환값을 받아줄 변수 선언.
        string returnVaue = GetString();
        Debug.Log(returnVaue);
    }
        
    

    //[1] 반환값이 있는 함수 만들기(선언, 정의)
    // 반환값이라는 string(문자열)을 반환하는 함수.
    string GetString()
    {
        return ("반환값(RetrunValue)");
    }
}
