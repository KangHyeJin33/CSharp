using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;

        if (score >= 60) // 만약, score가 60점 이상이면
        {
            Debug.Log("합격"); // "합격"이라고 출력하고,

        }
        else // 아니면,
        {
            Debug.Log("불합격"); // "불합격"이라고 출력.
        }
        
    }
}