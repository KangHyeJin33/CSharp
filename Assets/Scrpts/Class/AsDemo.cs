using UnityEngine;

// as 연산자 : 형식 변환하기, ~ 형식으로 변환이 가능하면 변환, 가능하지 않으면 변환불가하고 null을 반환한다.
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "반갑습니다.";
        string r1 = s as string; //r1을 as string으로 변환하라.
        Debug.Log($"[1] {r1}");

        object i = 1234;
        string r2 = i as string; // i를 as string으로 변환하라.
        if(r2 == null)
        {
            Debug.Log("[2] null입니다.");
        }

        object i2 = 5678;
        if(i2 is string) //i2가 string으로 변환이 가능한지 아닌지
        {
            string r3 = i2 as string; //참이면 r3가 i2의 string으로 변환이 가능하다
            Debug.Log("[3] {r3}");
        }
        else
        {
            Debug.Log("[3] 변환불가");
        }
    }
}
