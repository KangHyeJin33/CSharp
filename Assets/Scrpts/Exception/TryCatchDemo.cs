using UnityEngine;

public class TryCatchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int now = System.DateTime.Now.Second; // 현재 초.
            Debug.Log($"현재 초 : {now}");

            int result = 2 / (now % 2); //2를 2로 나눈 나머지를 result에 담는다. 0과 1 둘 중에 하나. 2 / 0 -> 오류. 1이 나와야 아래 실행문으로.
            Debug.Log("홀수 초에서는 정상처리");

        }
        catch
        {
            Debug.Log("짝수 초에서는 런타임 에러 발생");
        }
   }
}
