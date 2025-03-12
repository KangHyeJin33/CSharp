using UnityEngine;

// 내장형 구조체(DateTime) 사용.
public class DateTypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 현재 시간 출력
        Debug.Log($"현재 시간 : {System.DateTime.Now}"); // Now라는 변수안에 시간 출력.
        //[2] 현재 년, 월, 일, 시, 분, 초 출력
        Debug.Log(System.DateTime.Now.Year); // 몇 년인지 출력.
        Debug.Log(System.DateTime.Now.Month); // 월
        Debug.Log(System.DateTime.Now.Day); // 일
        Debug.Log(System.DateTime.Now.Hour); // 시
        Debug.Log(System.DateTime.Now.Minute); // 분
        Debug.Log(System.DateTime.Now.Second); // 초
        //[3] DateTime 구조체의 변수를 선언해서 사용
        System.DateTime now = System.DateTime.Now;
        Debug.Log(now.Date);
        Debug.Log(now.ToLongTimeString());
    }
}
