using UnityEngine;

// Index(�ε���) : �� ��°�� ��. [] �ȿ� ���� ����(��).
public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ũ�Ⱑ 3�� ������ �迭 �����ϰ� �ʱ�ȭ.
        int[] numbers = { 1, 2, 3 };
        //numbers[0] -> 1, numbers[1] -> 2, number[2] -> 3.

        // �迭�� �ε����� �����ϴ� ����. �׻� 0���� �ʱ�ȭ -> �ε���(��)�� ������ 0 ~ 2(n-1).
        int index = 0;

        Debug.Log(numbers[index++]); 
        Debug.Log(numbers[index++]); 
        Debug.Log(numbers[index++]);

        Debug.Log(numbers[--index]); 
        Debug.Log(numbers[--index]); 
        Debug.Log(numbers[--index]); 

    }
}
