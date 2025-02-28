using UnityEngine;

// 1,000,000 -> 여기서 ','는 '_'(언더스코어)로 표시한다
public class DygitNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 1_000_000; //int형 변수 num을 선언하고 100만으로 초기화.
        Debug.Log(num);
    }
}
