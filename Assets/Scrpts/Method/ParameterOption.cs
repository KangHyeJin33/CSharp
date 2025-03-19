using UnityEngine;

namespace Methood
{
    //OptionalParameter(선택적 매개변수) - 사용해도 되고, 생략해도 되고
    public class ParameterOption : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(5)); // 5+1=6. 결과 : 6
            Debug.Log(Add(5, 3)); // 5+3=8. 결과 : 8
        }

        //선택적 매개변수 : b를 선언과 동시에 초기값 설정
        //b 변수는 (사용해도 되고)생략하면 b의 값은 1이 된다 
        int Add(int a, int b = 1)
        {
            return a + b;
        }
    }
}
