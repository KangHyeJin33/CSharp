using UnityEngine;

public class TryCatchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int now = System.DateTime.Now.Second; // ���� ��.
            Debug.Log($"���� �� : {now}");

            int result = 2 / (now % 2); //2�� 2�� ���� �������� result�� ��´�. 0�� 1 �� �߿� �ϳ�. 2 / 0 -> ����. 1�� ���;� �Ʒ� ���๮����.
            Debug.Log("Ȧ�� �ʿ����� ����ó��");

        }
        catch
        {
            Debug.Log("¦�� �ʿ����� ��Ÿ�� ���� �߻�");
        }
   }
}
