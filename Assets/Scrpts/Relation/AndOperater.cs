using UnityEngine;


// AndOperater(And ������) : && -> �� �� ���� ���� ��.(�ϳ��� false�� false!)
// ��� : true �Ǵ� false
public class AndOperater : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �� �� ���� ���� ��.
        Debug.Log(true && true); // ��(true)�� ��(true)�� �� �� ��(true)���� -> ��� : true

        //[2] �� �߿� �ϳ��� �����̸�.
        Debug.Log(true && false); // false
        Debug.Log(false && true); // false

        //[3] �� �� �����̸� ����.
        Debug.Log(false && false); // false
    }
}
