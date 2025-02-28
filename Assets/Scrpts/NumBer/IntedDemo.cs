using UnityEngine;


//integer : 정수형 변수
public class IntedDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수가 가질 수 있는 가장 작은 값
        int min = -2147483648;
        //int형 변수가 가질 수 있는 가장 큰 값
        int max = 2147483647;

        Debug.Log("int 변수의 최소 값 : " + min);
        Debug.Log("int 변수의 최대 값 : " + max);
    }

}
