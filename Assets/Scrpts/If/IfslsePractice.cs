using UnityEngine;

public class IfslsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string medal = ""; // 빈 값으로 변수 초기화.

        if (score >= 90)
        {
            medal = "금메달";
            //Debug.Log("금메달을 수상하였습니다.");
        }
        else // 0~89점일때
        {
            if (score >= 80)
            {
                medal = "은메달";
                //Debug.Log("은메달을 수상하였습니다.");
            }
            else // 0~79점일때
            { 
                if(score >=70)
                {
                    medal = "동메달";
                }
                else // 0~69점일때,
                {
                    medal = "노메달";
                }
            }

    }
        Debug.Log($"{medal}을 수상하였습니다.");
  }
}
/*
[Q]
score가 90이상이면 금메달 출력, 80이상이면 은메달 출력,
70이상이면 동메달 출력, 그 외 나머지는 노메달 출력.
score는 85점.

[output]
()메달을 수상하였습니다.
 */