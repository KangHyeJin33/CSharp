using UnityEngine;

namespace PrivatePulic
{
    // 일요일~토요일까지 출력하는 함수 만들기
    public class Schedule
    {
        //[1] 배열 필드 선언 - 전역변수
        string[] weekDays = { "Sun", "Mon", "Tue", "Wen", "Thu", "Fri", "Sat" };

        //[2] 요일 출력하는 메서드
        public void PrintWeekDays()
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                Debug.Log(weekDays[i]);
            }
        }
    }
}