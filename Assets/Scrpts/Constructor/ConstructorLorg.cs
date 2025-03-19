using UnityEngine;

namespace Constructor
{
    public class ConstructorLorg
    {
        //기본 생성자
        public ConstructorLorg()
        {
            Debug.Log("기본 생성자 호출");
        }

        //string 매개변수가 있는 생성자 선언
        public ConstructorLorg(string message)
        {
            Debug.Log($"오버로드된 생성자 실행 : {message}");
        }
    }
}
