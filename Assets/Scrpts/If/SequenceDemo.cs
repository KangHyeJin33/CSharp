using UnityEngine;

// ������ : ������ �Ʒ��� ������� ��ɹ��� ����. (ex. ���� -> ���)
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 100; // ���� ���� �����ϴ� ���� ����.
        int eng = 90; // ���� ���� �����ϴ� ���� ����.

        int total = 0; // ����.
        double avg = 0.0; // ��� ����.

        //[2] ������ �� ����.
        total = kor + eng; // ���� ���ϱ�.
        avg = total / 2.0; //��� ���ϱ�.

        //[3] ���� ���.
        Debug.Log($"���� : {total}");
        Debug.Log($"��� : {avg}");

    }
}
/*
< ��� >
: ���α׷��� �帧(����)�� ���ϴ� ����.
- ����
1. ������ : ������ �Ʒ��� ������� ��ɹ��� ����. (ex. ���� -> ���) 
2. ���ǹ� : 
3. �ݺ���
 */