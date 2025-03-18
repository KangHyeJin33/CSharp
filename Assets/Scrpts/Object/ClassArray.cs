using UnityEngine;

//인스턴스 배열 만들기
// 특정 클래스 형식의 배열을 선언, 요소수 생성 => 배열 요소들의 각각 인스턴스를 생성한 후 사용
public class CategoryClass // 클래스 생성
{
    public void Print(int i) => Debug.Log($"카테고리 {i}"); // 메소드 생성
}


public class ClassArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] CategoryClass의(클래스) 배열 선언
        CategoryClass[] categories = new CategoryClass[3]; // new : 요소수 생성. 

        //[2] 배열 요소들의 각각 인스턴스 생성
        categories[0] = new CategoryClass(); // 0번방에 인스턴스를 채워넣음.
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        //[3] 사용
        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i); //각각의 방에 있는 객체들을 하나씩 꺼내서 사용(출력).
        }

    }
}
