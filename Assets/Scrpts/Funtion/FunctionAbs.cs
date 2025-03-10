using UnityEngine;

// abs(절대값)을 구하는 함수 만들기.
// -5의 절대값은 5, 5의 절대값은 5, -99의 절대값은 99, 143의 절대값은 143.
public class FunctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // -21의 절대값을 구하고 출력하기.
        int number = -21;
        //int abs = Abs(number);
        int abs = Mathf.Abs(number);
        Debug.Log($"{number}의 절대 값은 {abs}");
        
    }

    //매개변수로 들어온 정수의 절대값을 반환 하는 함수.
    int Abs(int num)
    {
        /*if(num < 0)
        {
            return -num; // 0보다 작으면 -num으로 반환. ex. 매개변수가 -면 --로 더 하면 정수(절대값)가 됨.
        }
        else
        {
            return num;
        }*/

        return (num < 0) ? -num : num;
    }

}
