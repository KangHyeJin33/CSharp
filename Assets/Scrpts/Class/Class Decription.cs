using UnityEngine;


public class ClassDecription : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Run(); //�޼��� ȣ�� : ���� Ŭ����(ClassDescription)�� �޼��� ȣ�� ����.
        ClassDecription.Run(); //Ŭ���� ������ �޼��� ȣ��.
    }

    //ClassDescription��� Ŭ������ Run (����) �޼���(�Լ�).
   static void Run()
   {
        Debug.Log("ClassDescription��� Ŭ������ Run �޼���");
   }
}
/*
 Class(Ŭ����) - C# �⺻�� �Ǵ� ����.
: �ϳ��� �̸����� ���� �ٸ�(������) �����͵�� �Լ����� ��� �����ϴ� �׸�(����).
: ...

public class (Ŭ�����̸�) //�⺻ Ŭ����.
{
    
}
  
 */
