using UnityEngine;


// AndOperater(And 연산자) : && -> 둘 다 참일 때만 참.(하나라도 false면 false!)
// 결과 : true 또는 false
public class AndOperater : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘 다 참일 때만 참.
        Debug.Log(true && true); // 앞(true)과 뒤(true)가 둘 다 참(true)인지 -> 결과 : true

        //[2] 둘 중에 하나라도 거짓이면.
        Debug.Log(true && false); // false
        Debug.Log(false && true); // false

        //[3] 둘 다 거짓이면 거짓.
        Debug.Log(false && false); // false
    }
}
