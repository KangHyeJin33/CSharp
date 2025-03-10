using JetBrains.Annotations;
using UnityEngine;

public class ArrayPrectice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] arr = { { 1, 0, 0 }, { 1, 1, 0 }, { 0, 0, 1 } };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    arr[i, j] = 1;
                }
                else
                {
                    arr[i, j] = 0;
                }
            }
        }

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Debug.Log("================================================");
                Debug.Log($"arr[{i}][{j}] : {arr[i, j]}");
             
            }
            //Console.WriteLine(new string('-', cols * 4));
        }
        Debug.Log("================================================");
    } 

    }


/*
[Q]
3행3열의 2차원 배열을 만들고
배열의 값을 행과 열의 인덱스가 같으면 1, 행과 열의 인덱스가 틀리면 0으로 저장 하세요. 
저장하는 방법을 이중 for문을 이용하세요.

1, 0, 0
0, 1, 0
0, 0, 1

[출력]
arr[0, 0] : 1
arr[0, 1] : 0
...
arr[2, 2] : 1
 */