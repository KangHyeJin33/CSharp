using UnityEngine;

// 1,000,000 -> ���⼭ ','�� '_'(������ھ�)�� ǥ���Ѵ�
public class DygitNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 1_000_000; //int�� ���� num�� �����ϰ� 100������ �ʱ�ȭ.
        Debug.Log(num);
    }
}
