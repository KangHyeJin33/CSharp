using UnityEngine;
using UnityEngine.Experimental.AI;

namespace Inheritance04
{

    public class InheritanceClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ParentClass 클래스의 인스턴스(객체) 생성하기
            ParentClass parent = new ParentClass();
            //parent.PrintMessage(); //에러 : 사용못함. 외부에서 접근불가능
            Debug.Log(parent.ToString());

            //ChildClass 클래스의 인스턴스(객체) 생성하기
            ChildClass child = new ChildClass();
            //child.Pringmassege(); // 외부에서 접근불가능
            child.Pringmassege2();

            //SubClass 클래스의 인스턴스(객체) 생성하기
            SubClass sub = new SubClass();
            //sub.PrintLog(); //protected로 선언되어 외부접근 불가. 
            sub.PringtDebug();
        }
    }
}
