using UnityEngine;

//������ ���� �������̳� ���ڿ��� ��밡��.
//[1] �������� �����ϴ� ������ ����.
enum Animals
{
    Rabbit,
    Dragon,
    Sanke
}
public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� �����ϰ� �ʱ�ȭ
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString(); // ToString() : ���ڿ��� �ٲ��ִ� �Լ�.
        Debug.Log($"Animals.Dragon : {num}, {str}");
    }
}
