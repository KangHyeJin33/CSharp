using UnityEngine;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string 변수 str 선언하고 빈 값으로 초기화
        string str = "";
        str = System.String.Empty; // 빈 값(절대 null은 아님)으로 저장
        str = " ABC Def Fed Cba "; // 앞 뒤에 공백 하나씩 주어서 값 저장

        Debug.Log(str);
        Debug.Log(str.Length); // 문자열 길이 구하기
        Debug.Log(str[5]); // 배열로 5번째 공간의 문자'D' 출력.
        Debug.Log(str.ToUpper()); // ToUpper() -> 인스턴스 메소드. 대문자 출력. 
        Debug.Log(str.ToLower()); // 소문자 출력.

        //공백 제거
        Debug.Log(str.Trim()); //앞과 뒤 양쪽 공백 제거
        Debug.Log(str.TrimStart()); //문자열 앞부분 공백 제거
        Debug.Log(str.TrimEnd()); //문자열 뒷부분 공백 제거

        //검색
        Debug.Log(str.IndexOf('e')); //'e'가 위치한 인덱스 가져오기
        Debug.Log(str.Substring(5, 3)); //5번 인덱스부터 3글자 가져오기. 'D'부터
        Debug.Log(str.Substring(5)); //5번 인덱스부터 끝까지 가져오기
        Debug.Log(str.Remove(5, 3)); //5번 인덱스부터 3글자 삭제

        //비교
        Debug.Log(str[1] == str[15]); //1번 인덱스와 15번 인덱스가 같은지. false.
        Debug.Log("ABC".Equals("Abc")); //false
        Debug.Log(System.String.Compare("BAC", "Bac")); //같으면 0 반환, 다르면 1(앞이 크면) 또는 -1(뒤가 크면) 반환.

        //연결
        var hi1 = "안녕";
        var hi2 = "하세요";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}, {hi2}"); //보간법
        Debug.Log(System.String.Format("{0}{1}", hi1, hi2)); //{0}번에 hi1, {1}번에 hi2

        //Format
        Debug.Log(System.String.Format("{0:C}", 1000)); //C : 통화량(화폐단위)
        Debug.Log(System.String.Format("{0:#,###}", 100000)); //화폐 #으로 백단위(세자리) 콤마 적용

        //분리하기 - 제공되어진 전체 문자열 공백 제거
        string[] strArray = str.Trim().Split(' '); //앞뒤 공백 제거해서
        string strAll = ""; //strAll에 누적

        foreach(var s in strArray)
        {
            //Debug.Log(s);
            strAll = strAll + s;
        }
        Debug.Log(strAll);
    }
}
