using Unity.VisualScripting;
using UnityEngine;

// ���ڿ� ��.
public class StringCompair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        string s2 = "Hello";

        // ����, s1�� s2�� ������ Same�̶�� ���.
        if(s1 == s2)
        {
            Debug.Log("s1�� s2�� �����Ƿ� Same.");
        }

        // 
        bool bln = false;

        // ����, bln���� false�̸� ���๮�� ����.
        if(bln == false)
        {
            // ���๮1 -> Debug.Log($"bln���� {bln}(��)�� false.");
            //���๮ 2
            Debug.Log("bln : " + bln);
        }

        // !bln���� true�̸� ���๮�� ����.
        if(!bln)
        {
            Debug.Log("!bln : " + !bln);
        }
    }
}
