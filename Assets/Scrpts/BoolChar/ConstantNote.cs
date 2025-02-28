using UnityEngine;

public class ConstantNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 변수
        string name = "홍길동";
        name = "이순신"; //변수라서 수정 가능.

        // 상수
        const int AGE = 20; //AGE를 20으로 고정.
        //AGE = 21; //'const'를 붙여서 상수가 되어 고정값이 있기 때문에 수정 불가능. 수정하면 에러 발생.

        //변수, 상수
        Debug.Log($"{name} - {AGE}");


    }

}
