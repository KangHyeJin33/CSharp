using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Number = 3;
        string Name = "홀수";
        Debug.Log($"해당 숫자는 {Number}" + $"은(는) {Name} 입니다.");
    }


}
/*
[Q]
3, 홀수를 변수선언 하고 저장한다.
문자열 보간법을 이용해서 저장된 데이터 출력.

[OutPut]
3은(는) 홀수입니다.

 */
