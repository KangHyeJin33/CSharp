using UnityEngine;

//null 연산자 : ??(null 병합연산자), ?.(null 조건부 연산자)
public class NullNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ??(null 병합연산자)
        string nullVallue = null;
        string messge = "";

        //message 변수 초기화
        /* if(nullVallue == null)
         {
             messge = "null이면 새로운 값으로 초기화";
         }*/
        messge = nullVallue ?? "null이면 새로운 값으로 초기화"; // ?? 앞이 null이면 "~"값으로 초기화하라.
        Debug.Log(messge);

        // ?.(null 조건부 연산자)
        int? len; //message 길이를 저장하는 변수
        string msg = null;

        /*if (msg != null)
        {
           len = msg.Length;
        }
        else
        {
            len = null;
        }*/
        // message가 null이면 null을 반환, null이 아니면 ?. 뒤에 있는 값(.Length - 길이)을 반환.
        len = msg?.Length; //len에 null을 저장

        msg = "안녕하세요";
        len = msg?.Length;
        Debug.Log(len);

    }
}
