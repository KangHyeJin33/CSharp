// using 이라는 네임스페이스를 사용할 때
/*
using UnityEngine;

public class UsingDemo: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/

// using 네임스페이스를 사용하지 않으면

using UnityEngine;

public class UsingDemo : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //네임스페이스.클래스이름.메서드()= 명령문. 메서드=함수이름
        UnityEngine.Debug.Log("Hello World!!!");
    }
}