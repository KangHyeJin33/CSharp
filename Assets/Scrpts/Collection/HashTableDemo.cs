using UnityEngine;
using System.Collections;

//Hashtable : 정수 형식이나 문자열 형식의 인덱스를 사용하여 데이터(값)들을 저장, 관리하는 클래스.
// [0], [1], [2], ["문자열"], ["이름"] 으로 사용이 가능.
public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Hashtable 클래스의 인스턴스(객체, 개체)를 생성
        Hashtable hash = new Hashtable();

        //[2] 데이터 입력(넣기) : 정수 형식이나 문자열 형식의 인덱스 사용
        hash[0] = "대한민국";
        hash["시 이름"] = "서울특별시";
        hash["구 이름"] = "강동구";

        //[3] 데이터 사용하기
        /*Debug.Log(hash[0]);
        Debug.Log(hash["시 이름"]);
        Debug.Log(hash["구 이름"]);*/

        foreach (var o in hash.Keys)
        {
            Debug.Log($"{o.ToString()} - {hash[o]}");
        }
    }
}
