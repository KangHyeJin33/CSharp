using UnityEngine;

public class ClassMember
{
    //[1] 정적(static) 메서드
    public static void StaticMethood()
    {
        Debug.Log("[1] 정적(static)메서드");
    }

    //[2] 인스턴스(Instance) 메서드
    public void InstanceMethood()
    {
        Debug.Log("[2] 인스턴스(Instans) 메서드");
    }
}
