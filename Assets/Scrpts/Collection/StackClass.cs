using System.Collections; //System�� Collections ���ӽ����̽��� ����Ѵ�
using UnityEngine;

// Collections : Stack, Queue, ArrayList, Hashtable. - Class
public class StackClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Stack Ŭ������ �ν��Ͻ�(��ü) �������� �޼ҵ� ��밡��
        Stack st = new Stack();

        //���ÿ� ������ �ֱ� : Push(�޼ҵ�)
        st.Push("First"); //�����̶�� �÷��ǿ� ��(First) ����
        st.Push("Second");

        //���ÿ��� ������ ������ : Pop(�޼ҵ�)
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());
    }
}
