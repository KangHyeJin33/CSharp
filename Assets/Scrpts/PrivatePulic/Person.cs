using UnityEngine;

namespace PrivatePulic
{
    //필드의 종류
    public class Person
    {
        //[1] 변수 형식의 필드
        private string name = "홍길동";
        //[2] 상수 형식의 필드
        private const int AGE = 21; // 상수는 꼭 'const'가 있어야 함
        //[3] 읽기 전용 형식의 필드
        private readonly string NickNmae = "도깨비";
        //[4] 배열 형식의 필드
        private string[] address = { "서울", "수원", "인천" };
        //[5] object(객체) 형식의 필드
        private object obj = System.DateTime.Now.ToShortTimeString();

        // public 메서드
        public void ShowProfile()
        {
            Debug.Log($"이름 : {name}, 나이 : {AGE}, 별명 : {NickNmae}");
        }
    }
}
