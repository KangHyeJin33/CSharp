using UnityEngine;

public class ClassMember
{
    //[1] ����(static) �޼���
    public static void StaticMethood()
    {
        Debug.Log("[1] ����(static)�޼���");
    }

    //[2] �ν��Ͻ�(Instance) �޼���
    public void InstanceMethood()
    {
        Debug.Log("[2] �ν��Ͻ�(Instans) �޼���");
    }
}
