using UnityEngine;

//Exception 클래스를 이용하여 예외내용 알아보기
public class ExceptionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string inputNumber = "3.14";
        int number = 0;

        try
        {
           number = System.Convert.ToInt32(inputNumber); //정수형으로 변환
            Debug.Log($"입력한 값은 {number}입니다");
        }
        catch (System.FormatException fe) //FormatException : 형 변환 시 오류 체크하는 함수
        {
            Debug.Log(fe.Message);
            Debug.Log($"{inputNumber}는 정수이여야 합니다"); //오류 일시 메세지 출력
        }
    }
}
