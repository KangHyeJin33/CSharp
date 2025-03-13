using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5;
        int y = 5;
        int r = 0;

        try //예외가 발생할 가능성이 있는 명령문
        {
            //[1]
            r = x / y; // r = 1
            Debug.Log($"{x} / {y} = {r}");
        }
        catch //try 절에서 예외가 발생하면 catch절을 실행
        {
            //[2]
            Debug.Log("예외가 발생 했습니다");
        }
        finally //try절에서 예외가 발생하던 안하던 상관없이 실행
        {
            //[3]
            Debug.Log("프로그램을 종료 합니다");
        }

        // 만약, try절에서 catch(예외)가 발생하면 : [1] -> [2] -> [3]
        // 발생 안하면 : [1] -> [3]
    }
}
