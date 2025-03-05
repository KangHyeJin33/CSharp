using UnityEngine;

// Not 연산자(NotOperator) : 부정 연산자. -> ! (참이면 거짓, 거짓이면 참으로 변환). $$ 또는 || 연산자와 달리 항이 1개라 단항 연산자.
// 결과 : true, false.
public class NotPerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 참일 때.
        Debug.Log(!true); // Not true -> 거짓(flase)

        //[2] 거짓일 때.
        Debug.Log(!false); // Not false -> 참(true)

        //[3]
        bool bln = false;

        Debug.Log(!bln); // -> true
        Debug.Log(!!bln); // -> false
        Debug.Log(!(!(!bln))); // -> true
    }
}
