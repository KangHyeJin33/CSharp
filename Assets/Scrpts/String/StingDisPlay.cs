using UnityEngine;

//문자열 묶는 방법(문자열 꾸미기) : 3가지.
public class StingDisPlay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = ""; //displayName은 string 타입의 변수
        var firsName = "길동";
        var lastName = "홍";

        //output : "이름 : 홍길동"

        //[1] string 더하기(+) 연산자 사용
        displayName = "이름 : " + lastName + firsName;
        Debug.Log(displayName);

        //[2] string.Foramt() 메서드 사용
        displayName = string.Format("이름 : {0}{1}", lastName, firsName); //{0} : 콤마 다음 첫번째, {1} : 첫번째 다음 두번째.
        Debug.Log(displayName);

        //[3] 문자열 보간법 사용
        displayName = $"이름 : {lastName}{firsName}";
        Debug.Log(displayName);
    }
}
