using UnityEngine;

//Exception Ŭ������ �̿��Ͽ� ���ܳ��� �˾ƺ���
public class ExceptionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string inputNumber = "3.14";
        int number = 0;

        try
        {
           number = System.Convert.ToInt32(inputNumber); //���������� ��ȯ
            Debug.Log($"�Է��� ���� {number}�Դϴ�");
        }
        catch (System.FormatException fe) //FormatException : �� ��ȯ �� ���� üũ�ϴ� �Լ�
        {
            Debug.Log(fe.Message);
            Debug.Log($"{inputNumber}�� �����̿��� �մϴ�"); //���� �Ͻ� �޼��� ���
        }
    }
}
