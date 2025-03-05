using UnityEngine;

// 두 개의 정수의 차이(빼기)를 양의 정수로(큰수 - 작은수) 구하시오.
public class NumberDoifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = -3;
        int second = -8;
        int diff = 0; //두 수의 차이.

        // 큰 수 판별식.
        if (first >= second)
        {
            diff = first - second;
            
         }
        else
        {
            diff = second - first;
        }
        Debug.Log("diff : " + diff);
    }
}
