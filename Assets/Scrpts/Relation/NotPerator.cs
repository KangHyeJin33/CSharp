using UnityEngine;

// Not ������(NotOperator) : ���� ������. -> ! (���̸� ����, �����̸� ������ ��ȯ). $$ �Ǵ� || �����ڿ� �޸� ���� 1���� ���� ������.
// ��� : true, false.
public class NotPerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� ��.
        Debug.Log(!true); // Not true -> ����(flase)

        //[2] ������ ��.
        Debug.Log(!false); // Not false -> ��(true)

        //[3]
        bool bln = false;

        Debug.Log(!bln); // -> true
        Debug.Log(!!bln); // -> false
        Debug.Log(!(!(!bln))); // -> true
    }
}
