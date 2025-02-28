using UnityEngine;

public class Varirable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 10;
        int second = 20;
        int third = 30;

        Debug.Log("첫번째 숫자 : " + first + "\n");
        Debug.Log("두번째 숫자 : " + second + "\n");
        Debug.Log("세번째 숫자 : " + third + "\n");

        
      //Debug.Log(first + "," + second + "," + third); -> 한 줄로 출력 가능
        
    }

}

/*
[Q]
변수 : first, second, third 정의하고 값 대입하여 아래내용 출력.

[output]
10, 20, 30
*/
