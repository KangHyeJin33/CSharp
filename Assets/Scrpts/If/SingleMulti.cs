using UnityEngine;

// ���๮ : �ܹ�(1��), ����(2�� �̻�).
public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ����, ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����Ѵ�.
        /* if(���ǽ�)
         {
            // ���๮1
            // ���๮2
            // ...
         }
         */

        // �ܹ��� {} ���๮�� 1��
        if(1 == 1)
        {
            Debug.Log("�ܹ� 1");
        }

        // {}�� ������ �Ǹ�, �ٷ� �Ʒ��� �ִ� 1�ٸ� ����.
        if (1 == 1)
     
            Debug.Log("�ܹ� 2");

        if (1 == 1) Debug.Log("�ܹ� 3");
        
        // ������ ���๮�� 2�� �̻��� ��.
        if(1 == 1)
            Debug.Log("���� 1"); // ���� O.
            Debug.Log("���� 2"); // ���� X.
    }
}
/*
< ��� >
: ���α׷��� �帧(����)�� ���ϴ� ����.
- ����
1. ������ : ������ �Ʒ��� ������� ��ɹ��� ����. (ex. ���� -> ���) 
2. ���ǹ�(if - else, switch) : ���ǿ� ���� ���� �ٸ� ��ɹ��� ����. 
ex.
if()
{
    
}
3. �ݺ���
 */