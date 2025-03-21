using UnityEngine;

namespace Inheritance07
{

    public class SeldeClass : MonoBehaviour
    {
        //Sealde(봉인) 클래스 : 최종 클래스, 더 이상 상속되지 못한다.
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Cat cat = new Cat();
            cat.Eat();
        }
    }
}
