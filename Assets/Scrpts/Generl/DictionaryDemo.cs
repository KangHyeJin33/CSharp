using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Dictionary(딕셔너리) 클래스의 인스턴스(객체, 개체) 생성
        IDictionary<string, string> data = new Dictionary<string, string>();

        //[2] Dictionary 데이터 넣기
        data.Add("시", "서울특별시");
        data.Add("구", "강동구");

        //[3] Dictionary 데이터 삭제
        data.Remove("시"); //Key 입력.

        //[4] Dictionary 데이터 넣기 - 인덱서를 사용해서 입력
        data["동"] = "천호동"; // Dictionary에선 ["동"]을 인덱서라고 부름.

        //[5] 키값은 중복이 불가하고 같은 키값으로 추가가 안된다
        try
        {
            //data["구"] = "강남구"; // 수정.
            data.Add("구", "강남구");
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        //[6] 사용
        foreach (KeyValuePair<string, string> item in data)
        {
            Debug.Log($"{item.Key} - {item.Value}");
        }

        //[7] 인덱서 사용
        Debug.Log(data["구"]);
    }
}
