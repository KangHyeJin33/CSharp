using UnityEngine;

//���ڿ� ���� ���(���ڿ� �ٹ̱�) : 3����.
public class StingDisPlay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = ""; //displayName�� string Ÿ���� ����
        var firsName = "�浿";
        var lastName = "ȫ";

        //output : "�̸� : ȫ�浿"

        //[1] string ���ϱ�(+) ������ ���
        displayName = "�̸� : " + lastName + firsName;
        Debug.Log(displayName);

        //[2] string.Foramt() �޼��� ���
        displayName = string.Format("�̸� : {0}{1}", lastName, firsName); //{0} : �޸� ���� ù��°, {1} : ù��° ���� �ι�°.
        Debug.Log(displayName);

        //[3] ���ڿ� ������ ���
        displayName = $"�̸� : {lastName}{firsName}";
        Debug.Log(displayName);
    }
}
