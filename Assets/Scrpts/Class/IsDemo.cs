using UnityEngine;

public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234; 
        object o = i; //박싱(boxing) : 값 형식의 데이터를 참조 형식의 데이터로 변경하는 것.
        Debug.Log(o);

        object obj = 9874; //오브젝트가 어떤 형태의 데이터를 가지고 있는지 모름.
        //int num = obj; //모르기 때문에 오류가 남.

        //언박싱(unboxing) : 참조 형식의 데이터를 값 형식의 데이터로 변경하는 것.(캐스트 또는 캐스팅 : 형변환)
        int num = (int)obj; //오브젝트가 어떤 형태의 데이터를 가지고 있는지 모르기 때문에 정수형(int)로 변환.

        Debug.Log(num);

        //is 연산자 : (특정)형식 비교하기
        object s = "안녕하세요.";
        object j = 4567;

        if(s is string) //s가 string형식인지 아닌지
        {
            Debug.Log($"[1] {s}는 null이 아니며 문자열 형식으로 변환이 가능합니다.");
        }

        if(j is int)
        {
            Debug.Log($"[2] {j}는 정수형으로 변환이 가능합니다.");
        }
    }
}
/*
값 형식 (vaule type) : 개체에 값 자체를 담고 있는 구조
참조 형식 (reference type) : 개체가 값을 담고 있고 또 다른 개체가 포인터로 바라보는 구조

object 데이터 형식 : object 형식의 변수에는 모든 형식의 데이터값을 저장(할당) 가능
박싱(boxing) : 값 형식의 데이터를 참조 형식의 데이터로 변경하는 것. 단점은 연산의 양이 많아 속도가 떨어지고, 비용이 비싸다.
언박싱(unboxing) : 참조 형식의 데이터를 값 형식의 데이터로 변경하는 것.(캐스트 또는 캐스팅 : 형변환)

is 연산자 : (특정)형식 비교하기
- 특정 형식인지 아닌지를 비교
- 특정 형식으로 변환이 가능하면 true, 그렇지 않으면 false.
 */
