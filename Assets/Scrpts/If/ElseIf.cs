using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // score가 90점 이상이면 A, 80점 이상이면 B, 70점 이상이면 C,
        // 60점 이상이면 D, 나머지 F.

        int score = 59;
        char grade = 'A';

        if (score >= 90)
        {
            grade = 'A';
        }
        else if (score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else if (score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        Debug.Log($"{grade}학점");
    }
}
