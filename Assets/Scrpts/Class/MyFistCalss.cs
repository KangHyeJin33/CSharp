using UnityEngine;

//정적 메서드 호출, 인스턴스 메서드 호출.
public class MyFistCalss : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 정적(static) 메서드 호출
        //호출 방법 : 클래스이름.메서드이름()
        ClassMember.StaticMethood();

        //[2] 인스턴스(Instance) 메서드 호출 -> InstanceMethood()
        //호출 방법
        
        ClassMember member = new ClassMember();
        member.InstanceMethood(); //인스턴스를 만들어서 호출한다.
    }
}
