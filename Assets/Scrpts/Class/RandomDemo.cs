using UnityEngine;

//Random Ŭ���� : �������� ���õ� ������, �޽������ �ִ� Ŭ����.
public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����(Random) Ŭ���� ��ü ����.
        System.Random random = new System.Random(); // Ŭ����(System.Random) ��ü�̸�(random) = (System.Random).

        //������ ������ ���ϱ�.
        Debug.Log(random.Next());
        //0~4 (0, 1, 2, 3, 4)�� �ϳ��� �� ���ϱ�
        Debug.Log(random.Next(5));
        //1~9 (1, 2, 3, 4, 5, 6, 7, 8, 9)�� �ϳ��� �� ���ϱ�
        Debug.Log(random.Next(1, 10)); //(1 -> ���۰�, 10 -> �� ��)
    }
}
