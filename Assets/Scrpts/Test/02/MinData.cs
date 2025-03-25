using UnityEngine;

public class MinData : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열 선언
        double[] Min = { -2, -5, -3, -7, -1 };

        //최소값 구하기

        for (int i = 0; i < Min.Length; i++)
        {
            if (Min[0] < Min[1])
            {
                Debug.Log(Min[1]);
                break;
            }

            if (Min[1] < Min[2])
            {
                Debug.Log(Min[2]);
                break;
            }
            if (Min[2] < Min[3])
            { 
                Debug.Log(Min[3]);
                break;
            }

            if (Min[3] < Min[4])
            {
                Debug.Log(Min[4]);
                break;
            }

        }
    }
}
