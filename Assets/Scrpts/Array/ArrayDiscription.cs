using UnityEngine;

// Varlable(����) : ���α׷�(�����͸� �ٷ�� ���)���� ����ϴ� �����͸� ������ ���� �׸�.
// Array(�迭) : �ϳ��� �̸����� ���� ������ ������ ������ ���� ���� �׸�.
// ���� : ������Ÿ��[] ������(�̸�);
// ũ�� ���� : ������(�̸�) = new ������Ÿ��[ũ��]
public class ArrayDiscription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;

        //[1] �迭 ����.
        int[] numbers; //int�� �迭number�� �ϳ��� �� ������ ũ��� 4Bit.

        //[2] �迭�� ��Ҽ� ���� - �׸� ���� ����(�迭�� ũ��).
        numbers = new int[n]; // 0�� �� ~ 9�� ��.(10���� ��). 0 ~ n-1.

        //[3] �迭�� ���� �Ǵ� �ʱ�ȭ(����).
        numbers[0] = 3840; // 0�� ��.(�� ó���� �ִ�)
        numbers[1] = 2160;

        //[4] �迭�� ���
        Debug.Log(numbers[0] * numbers[1] * numbers[2]);


    }
}
