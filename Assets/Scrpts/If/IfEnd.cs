using UnityEngine;

// &&, ||
public class IfEnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;

        // 조건식이 두가지 일때. 1. number가 1234와 같은지?. 2. number가 1000이상 인지?)
        // 두가지 조건을 모두 만족하면(&&) 맞습니다.출력.
        if(number == 1234 && number >= 1000)
        {
            Debug.Log("맞습니다.");
        }

        // 조건식이 두가지 일때. 1. number가 1234와 같은지?. 2. number가 1000이하 인지?)
        // 두가지 조건 중 하나라도 만족하면(||) 실행문 실행.
        if(number == 1234 || number <= 1000)
        {
            Debug.Log("하나라도 참이면 참");
        }
    }
}
