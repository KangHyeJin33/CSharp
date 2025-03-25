using UnityEngine;

namespace Override
{
    public class MethodOverrideNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Developer 클래스 객체 만들기
            Developer dev = new Developer();
            Debug.Log(dev);

            WebDeveloper wDev = new WebDeveloper();
            Debug.Log(wDev);

            MobileDeveloper mobile = new MobileDeveloper();
            Debug.Log(mobile);
        }
    }
}
