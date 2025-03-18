using UnityEngine;

public class MaxPratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] data = { -2, -5, -3, -7, -1 };
        int max = int.MinValue;

        for (int i = 0; i < data.Length; i++)
        { 
                if (data[i] > max)
                {
                    max = data[i];
           
                }
                
            }
        Debug.Log($"최대 값은 : {max}");
    }
    }


/*
입력데이터 {-2, -5, -3, -7, -1}
입력 데이터 중에서 최대값을 구하세요

[output]
최대값 : -1

 */