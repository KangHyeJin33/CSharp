using UnityEngine;

// RelationalOpertor(관계형 연산자, 비교 연산자)
//  a < b (a가 b보다 작음), a <= b (a가 작거나 같음), a > b (a가 b보다 큼), a >= b (a가 b 보다 크거나 같음, a == b (a와 b가 같음), a != b (a는 b와 다름)
//  결과 : true(참), false(거짓).
public class RelaternalOper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y); // x(3)가 y(5)보다 작은지? (=true인지 flase) -> 결과 : true(참) 출력.
        Debug.Log(x <= y); // x가 y보다 작은지? -> true
        Debug.Log(x > y); // x가 y보다 큰지? -> false
        Debug.Log(x >= y);// x가 y보다 크거나 같은지? -> false
        Debug.Log(x == y); // x가 y와 같은지? -> false
        Debug.Log(x != y); // x는 y와 다른지? -> true

        Debug.Log("AAA" == "aaa"); // 대문자와 소문자를 구분하기 때문에 false.
       
    }
}
