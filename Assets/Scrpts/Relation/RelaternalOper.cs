using UnityEngine;

// RelationalOpertor(������ ������, �� ������)
//  a < b (a�� b���� ����), a <= b (a�� �۰ų� ����), a > b (a�� b���� ŭ), a >= b (a�� b ���� ũ�ų� ����, a == b (a�� b�� ����), a != b (a�� b�� �ٸ�)
//  ��� : true(��), false(����).
public class RelaternalOper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y); // x(3)�� y(5)���� ������? (=true���� flase) -> ��� : true(��) ���.
        Debug.Log(x <= y); // x�� y���� ������? -> true
        Debug.Log(x > y); // x�� y���� ū��? -> false
        Debug.Log(x >= y);// x�� y���� ũ�ų� ������? -> false
        Debug.Log(x == y); // x�� y�� ������? -> false
        Debug.Log(x != y); // x�� y�� �ٸ���? -> true

        Debug.Log("AAA" == "aaa"); // �빮�ڿ� �ҹ��ڸ� �����ϱ� ������ false.
       
    }
}
