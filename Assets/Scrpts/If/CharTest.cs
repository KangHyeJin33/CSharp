using UnityEngine;

public class CharTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char c = 'a';

        // �빮�� �Ǻ���.
        if(c >= 'A' && c <= 'Z') // �� ������ ��� �����ϸ�,
        {
            Debug.Log($"{c}�� �빮�� �Դϴ�."); // c�� �빮��.
        }
        else
        {
            Debug.Log($"{c}�� �ҹ��� �Դϴ�.");
        }
    }
}
