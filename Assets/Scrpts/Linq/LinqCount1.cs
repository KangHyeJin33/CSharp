using System.Linq;
using UnityEngine;

public class LinqCount1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool형 배열 변수에서 true값의 갯수, false값의 개수 구하기
        bool[] blns = { true, false, true, false, true };

        //전체 요소수 갯수 구하기
        Debug.Log(blns.Count()); //모두를 셈.
        //true 값의 개수
        Debug.Log(blns.Count(b => b == true)); // 조건식에 맞는 것을 반환
        //false 값의 개수
        Debug.Log(blns.Count(a => a == false));
    }
}
