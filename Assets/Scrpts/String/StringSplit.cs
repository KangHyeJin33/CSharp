using UnityEngine;

// Split() : 문자열 분리하기
//문자열에서 매개변수로 입력 받은 특정 구분(문)자를 사용하여 문자열 배열을 만든다.
public class StringSplit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string scr = "Red, Green, Blue";

        string[] colors = scr.Split(','); // 문자 ','를 기준으로 Split(분리) 하고, (분리한 문자열을) colors(문자배열)에 저장.

        for(int i = 0; i < colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }
    }
}
