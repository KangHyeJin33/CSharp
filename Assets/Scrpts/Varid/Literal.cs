using UnityEngine;


// Literal(값)
public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 만들기.
        int num; //정수형 변수 선언.
        double su; //실수형 변수 선언.
        bool flag; //부울형(true(참), false(거짓)) 변수 선언.
        string str; //문자열 변수 선언.
        char c; //문자형 변수 선언.

        //[2] 변수에 값을 저장
        num = 1234;
        su = 3.14159;
        flag = true;
        str = "안녕하세요.";
        c = 'a'; //문자형은 문자 한개만 가능.(ex. 영어의 경우 'a', 한글의 경우 '가')

        //[3] 변수 사용하기.
        Debug.Log("num : " + num);
        Debug.Log("su : " + su);
        Debug.Log("flag : " + flag);
        Debug.Log("str : " + str);
        Debug.Log("c : " + c);


    }

}
