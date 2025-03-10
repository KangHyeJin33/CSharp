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
3��3���� 2���� �迭�� �����
�迭�� ���� ��� ���� �ε����� ������ 1, ��� ���� �ε����� Ʋ���� 0���� ���� �ϼ���. 
�����ϴ� ����� ���� for���� �̿��ϼ���.

1, 0, 0
0, 1, 0
0, 0, 1

[���]
arr[0, 0] : 1
arr[0, 1] : 0
...
arr[2, 2] : 1
 */