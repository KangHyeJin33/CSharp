using UnityEngine;

// as ������ : ���� ��ȯ�ϱ�, ~ �������� ��ȯ�� �����ϸ� ��ȯ, �������� ������ ��ȯ�Ұ��ϰ� null�� ��ȯ�Ѵ�.
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "�ݰ����ϴ�.";
        string r1 = s as string; //r1�� as string���� ��ȯ�϶�.
        Debug.Log($"[1] {r1}");

        object i = 1234;
        string r2 = i as string; // i�� as string���� ��ȯ�϶�.
        if(r2 == null)
        {
            Debug.Log("[2] null�Դϴ�.");
        }

        object i2 = 5678;
        if(i2 is string) //i2�� string���� ��ȯ�� �������� �ƴ���
        {
            string r3 = i2 as string; //���̸� r3�� i2�� string���� ��ȯ�� �����ϴ�
            Debug.Log("[3] {r3}");
        }
        else
        {
            Debug.Log("[3] ��ȯ�Ұ�");
        }
    }
}
