using Unity.VisualScripting;
using UnityEngine;

//break로 무한루프 빠져 나오기.
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 무한루프 - 무한 반복
        /*for(; ;) // 무한 반복
        {

        }*/

        /*while(true) // 참 이면, 무한 반복.
        {

        }*/

        int number = 0;

        //number가 5이상이면, while문 종료.
        while(true) // 무한루프
        {
            //반복 실행문.
            Debug.Log(number);

            number++;
            if(number >=5)
            {
                break;
            }
    
        }

    }
}
