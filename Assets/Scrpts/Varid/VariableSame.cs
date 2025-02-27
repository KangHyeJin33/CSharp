using UnityEngine;

public class VariableSame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a, b, c; //실무에선 변수를 단어로 쓰기.

        // a, b, c 값 초기화 : 선언 시 값을 대입하지 않은 상태에서 처음으로 값을 저장할 때 초기화.
        //a = 10;
        //b = 10;
        //c = 10;
        a = b = c = 10;

        Debug.Log(a + "," + b + "," + c);
        

    }

}
