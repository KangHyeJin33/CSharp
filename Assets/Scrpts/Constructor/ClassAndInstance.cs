using Constructor;
using UnityEngine;

public class ClassAndInstance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Dog 클래스의 인스턴스 생성
        //Dog happy = new Dog(); // 에러 : 생성자가 있으면 함수가 자동으로 만들어지지않음.
        Dog happy = new Dog("해피");
        Debug.Log(happy.Cry());

        //Dog 클래스의 다른 인스턴스 생성
        Dog worry = new Dog("워리");
        Debug.Log(worry.Cry());
    }
}
