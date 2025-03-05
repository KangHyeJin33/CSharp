using Unity.VisualScripting;
using UnityEngine;

// 문자열 비교.
public class StringCompair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        string s2 = "Hello";

        // 만약, s1과 s2가 같으면 Same이라고 출력.
        if(s1 == s2)
        {
            Debug.Log("s1과 s2가 같으므로 Same.");
        }

        // 
        bool bln = false;

        // 만약, bln값이 false이면 실행문을 실행.
        if(bln == false)
        {
            // 실행문1 -> Debug.Log($"bln값이 {bln}(으)로 false.");
            //실행문 2
            Debug.Log("bln : " + bln);
        }

        // !bln값이 true이면 실행문을 실행.
        if(!bln)
        {
            Debug.Log("!bln : " + !bln);
        }
    }
}
