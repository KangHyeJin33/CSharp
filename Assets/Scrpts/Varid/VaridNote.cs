using UnityEngine;


// Varlable(변수) : 프로그램(데이터를 다루는 기술)에서 사용하는 데이터를 저장해 놓는 그릇.
public class VaridNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 변수 선언 또는 만들기.
        int i; // i라는 이름으로 (정수형)변수 선언.

        // [2] 변수에 값을 저장(대입, 할당, 초기화)하기.
        i = 1234;

        // [3] 변수에 들어있는 값 사용(참조)하기.
        Debug.Log(i);

    }

}
