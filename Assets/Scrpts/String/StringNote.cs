using UnityEngine;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string ���� str �����ϰ� �� ������ �ʱ�ȭ
        string str = "";
        str = System.String.Empty; // �� ��(���� null�� �ƴ�)���� ����
        str = " ABC Def Fed Cba "; // �� �ڿ� ���� �ϳ��� �־ �� ����

        Debug.Log(str);
        Debug.Log(str.Length); // ���ڿ� ���� ���ϱ�
        Debug.Log(str[5]); // �迭�� 5��° ������ ����'D' ���.
        Debug.Log(str.ToUpper()); // ToUpper() -> �ν��Ͻ� �޼ҵ�. �빮�� ���. 
        Debug.Log(str.ToLower()); // �ҹ��� ���.

        //���� ����
        Debug.Log(str.Trim()); //�հ� �� ���� ���� ����
        Debug.Log(str.TrimStart()); //���ڿ� �պκ� ���� ����
        Debug.Log(str.TrimEnd()); //���ڿ� �޺κ� ���� ����

        //�˻�
        Debug.Log(str.IndexOf('e')); //'e'�� ��ġ�� �ε��� ��������
        Debug.Log(str.Substring(5, 3)); //5�� �ε������� 3���� ��������. 'D'����
        Debug.Log(str.Substring(5)); //5�� �ε������� ������ ��������
        Debug.Log(str.Remove(5, 3)); //5�� �ε������� 3���� ����

        //��
        Debug.Log(str[1] == str[15]); //1�� �ε����� 15�� �ε����� ������. false.
        Debug.Log("ABC".Equals("Abc")); //false
        Debug.Log(System.String.Compare("BAC", "Bac")); //������ 0 ��ȯ, �ٸ��� 1(���� ũ��) �Ǵ� -1(�ڰ� ũ��) ��ȯ.

        //����
        var hi1 = "�ȳ�";
        var hi2 = "�ϼ���";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}, {hi2}"); //������
        Debug.Log(System.String.Format("{0}{1}", hi1, hi2)); //{0}���� hi1, {1}���� hi2

        //Format
        Debug.Log(System.String.Format("{0:C}", 1000)); //C : ��ȭ��(ȭ�����)
        Debug.Log(System.String.Format("{0:#,###}", 100000)); //ȭ�� #���� �����(���ڸ�) �޸� ����

        //�и��ϱ� - �����Ǿ��� ��ü ���ڿ� ���� ����
        string[] strArray = str.Trim().Split(' '); //�յ� ���� �����ؼ�
        string strAll = ""; //strAll�� ����

        foreach(var s in strArray)
        {
            //Debug.Log(s);
            strAll = strAll + s;
        }
        Debug.Log(strAll);
    }
}
