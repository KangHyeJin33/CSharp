using UnityEngine;

//Random 클래스 : 랜덤값과 관련된 변수들, 메스드들이 있는 클래스.
public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 랜덤(Random) 클래스 객체 생성.
        System.Random random = new System.Random(); // 클래스(System.Random) 객체이름(random) = (System.Random).

        //임의의 정수값 구하기.
        Debug.Log(random.Next());
        //0~4 (0, 1, 2, 3, 4)중 하나의 값 구하기
        Debug.Log(random.Next(5));
        //1~9 (1, 2, 3, 4, 5, 6, 7, 8, 9)중 하나의 값 구하기
        Debug.Log(random.Next(1, 10)); //(1 -> 시작값, 10 -> 끝 값)
    }
}
