using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int maxValue = GetMax(3, 5);
        Debug.Log($"3�� 5 �� ū ���� {maxValue}�Դϴ�.");

        float minValue = GetMin(-3f, -5f);
        Debug.Log($"-3�� -5 �� ���� ���� {minValue}�Դϴ�.");

    }

    int GetMax(int a, int b)
    {
    

        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    float GetMin(float x, float y)
    {
        

        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
    //3�� ������
    //int maxValue = (x > y) ? x : y; // ���ǽ��� ���̸� x�� ��ȯ, ���ǽ��� �����̸� y�� ��ȯ.
    //retrun maxValue;

    //retrun (x > y) ? x : y

    }

/*
[Q]
1. �Ű������� �Է� ���� �� ���� ���� �� ū ���� ��ȯ �ϴ� �Լ�.
2. �Ű������� �Է� ���� �� ���� ���� �� ���� ���� ��ȯ �ϴ� �Լ�.
3. (3, 5)�� �Է� �޾� ū �� ����ϱ�.
4. (-3, -5)�� �Է� �޾� ���� �� ����ϱ�.

[OutPut]
3�� 5 �� ū ���� (��ȯ ��)�̴�.
-3�� -5 �� ���� ���� (��ȯ ��)�̴�.
 */
