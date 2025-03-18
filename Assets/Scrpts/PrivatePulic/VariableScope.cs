using UnityEngine;

namespace PrivatePulic
{
    public class VariableScope : MonoBehaviour
    {
        // 필드 선언부
        string globalVariable = "전역변수"; //Field(필드, 전역변수, 멤버 변수)


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start() // private이 맨 앞에 생략되어 있음.
        {
            //[1] 지역변수 선언 및 사용
            string localVariable = "지역변수"; // private이 맨 앞에 생략되어 있음.
            Debug.Log(localVariable);

            //[2] 전역변수 사용
            Debug.Log(globalVariable);

            //[3] 함수 호출 - 전역변수 사용
            TestPrint();
        }
        void TestPrint() // private이 맨 앞에 생략되어 있음.
        {
            //Debug.Log(localVariable); // 에러 - Start()함수 코드블록('{}') 안에서만 사용.

            // [4] 전역변수 사용
            Debug.Log(globalVariable);
        }    
    }
}
