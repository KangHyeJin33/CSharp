using UnityEngine;
using UnityEngine.UIElements;

namespace Test
{
    public class TestClassNumber
    {
        //필드
        string[] number = { "일", "월,", "화", "수", "목", "금", "토" };

        //인스턴스 멤버 함수 만들기
        void Number(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                Debug.Log(number[i]);
            }
        }

        //정적 멤버 함수 만들기
        int Sum(int a, int b)
        {
            int sum = 0;
            return sum = a + b;
        }
    }
}
