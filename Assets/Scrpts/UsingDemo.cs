// using �̶�� ���ӽ����̽��� ����� ��
/*
using UnityEngine;

public class UsingDemo: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/

// using ���ӽ����̽��� ������� ������

using UnityEngine;

public class UsingDemo : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ӽ����̽�.Ŭ�����̸�.�޼���()= ��ɹ�. �޼���=�Լ��̸�
        UnityEngine.Debug.Log("Hello World!!!");
    }
}