using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3); // 관계 연산의 결과는 true와 false로 출력. && : 앞과 뒤가 참이면 참. 결과 -> true && true
        Debug.Log("r 값 : " + r); // true.

        r = (i != 3) || (j == 3); // false || false
        Debug.Log("r 값 : " + r); // false

        r = (i >= 5); // flase
        Debug.Log("!r 값 : " + !r); // !false -> true

        Debug.Log((1 == 1) || (1 != 1)); // true || false -> true

        //
        bool bln1 = true;
        bool bln2 = false;

        Debug.Log(bln1 && bln2); //bln1(true) && bln2(flase) -> flase
        Debug.Log(bln1 || bln2); //true || false -> true

    }
}


