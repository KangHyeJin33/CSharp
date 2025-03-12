using UnityEngine;

//[1] 동물들을 구분하는 열거형 생성.
// 열거형(정수형 상수값의 집합) 값은 순서대로 0부터 시작해서 1씩 증가한다.
enum Animale
{
    /*Horse, // 0. 값을 지정하지 않은 상태.
    Sheep, // 1.
    Monkey // 2.*/
    Horse, // 0
    Sheep = 5, // 1 -> 5
    Monkey = 5 // 2 -> 6. 앞의 상수값(2) + 1 = 3 
}

public class EnumIndexString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)Animale.Monkey); // 2.
    }
}
