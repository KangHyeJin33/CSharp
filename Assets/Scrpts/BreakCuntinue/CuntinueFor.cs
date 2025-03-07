using UnityEngine;

// continue문은 반복문에서 continue문을 만나면, continue문 아래에 있는 실행문을 실행하지 않고,
// 다음 반복문의 조건식을 판별한 다음 반복문 실행.
public class CuntinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1부터 5까지 홀수만 출력하는 프로그램.
        /*for(int i = 1; i <=5; i++)
        {
            if(i % 2 != 0) // i를 2로 나눴을 때 나머지가 0이 아니면 (홀수 판별식)
            Debug.Log(i);
        }*/

        //짝수 제외 홀수만 출력.
        for (int i = 1; i <= 5; i++)
        {
            if (i % 2 == 0) // i를 2로 나눴을 때 나머지가 0이 아니면 (짝수 판별식)
            {
                continue; //아래 Debug.Log(i);를 만나면 해당 실행문을 실행하지않고 조건식(for문)으로 간다. 현재 반복 실행중인 반복문을 중지하고 다음 반복문으로 이동하라.
            }
                Debug.Log(i); // i를 출력한다.
        }
       

    }
}
