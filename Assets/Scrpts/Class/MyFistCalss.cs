using UnityEngine;

//���� �޼��� ȣ��, �ν��Ͻ� �޼��� ȣ��.
public class MyFistCalss : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����(static) �޼��� ȣ��
        //ȣ�� ��� : Ŭ�����̸�.�޼����̸�()
        ClassMember.StaticMethood();

        //[2] �ν��Ͻ�(Instance) �޼��� ȣ�� -> InstanceMethood()
        //ȣ�� ���
        
        ClassMember member = new ClassMember();
        member.InstanceMethood(); //�ν��Ͻ��� ���� ȣ���Ѵ�.
    }
}
