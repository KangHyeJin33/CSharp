using UnityEngine;

public class Varirable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 10;
        int second = 20;
        int third = 30;

        Debug.Log("ù��° ���� : " + first + "\n");
        Debug.Log("�ι�° ���� : " + second + "\n");
        Debug.Log("����° ���� : " + third + "\n");

        
      //Debug.Log(first + "," + second + "," + third); -> �� �ٷ� ��� ����
        
    }

}

/*
[Q]
���� : first, second, third �����ϰ� �� �����Ͽ� �Ʒ����� ���.

[output]
10, 20, 30
*/
