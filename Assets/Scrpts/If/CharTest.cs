using UnityEngine;

public class CharTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char c = 'a';

        // 대문자 판별식.
        if(c >= 'A' && c <= 'Z') // 두 조건을 모두 만족하면,
        {
            Debug.Log($"{c}는 대문자 입니다."); // c는 대문자.
        }
        else
        {
            Debug.Log($"{c}는 소문자 입니다.");
        }
    }
}
