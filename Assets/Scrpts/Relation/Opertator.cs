using UnityEngine;

// LogicalOperator(논리 연산자) -> &&, ||, !(nat 연산자)
// OrOpertator (Or 연산자) : || -> 하나라도 참이면 참.
// 결과 : true, false
public class Opertator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘 다 참일 때.
        Debug.Log(true || true); // 둘 다 참일 때 결과 -> true

        //[2] 둘 중에 하나가 참일 때.
        Debug.Log(true || false); // 결과 -> true
        Debug.Log(false || true); // 결과 -> true

        //[3] 둘 다 거짓일 때.
        Debug.Log(false || false); // 결과 -> false
    }
}
