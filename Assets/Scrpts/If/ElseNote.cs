using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;

        if (score >= 60) // ����, score�� 60�� �̻��̸�
        {
            Debug.Log("�հ�"); // "�հ�"�̶�� ����ϰ�,

        }
        else // �ƴϸ�,
        {
            Debug.Log("���հ�"); // "���հ�"�̶�� ���.
        }
        
    }
}