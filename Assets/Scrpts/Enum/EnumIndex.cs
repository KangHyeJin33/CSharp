using UnityEngine;

//열거형 값을 정수형이나 문자열로 사용가능.
//[1] 동물들을 구분하는 열거형 생성.
enum Animals
{
    Rabbit,
    Dragon,
    Sanke
}
public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //열거형 변수 선언하고 초기화
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString(); // ToString() : 문자열로 바꿔주는 함수.
        Debug.Log($"Animals.Dragon : {num}, {str}");
    }
}
