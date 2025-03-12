using Unity.VisualScripting;
using UnityEngine;

//[1] ����ü ���� �Ǵ� ���� : ���� �����͸� �����ϴ� ����ü ����.
struct UserInfo
{
    public string name; // �� �̸�
    public int age; // �� ����
    // ...
}

public class StrunctArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����ü ���� ����
        UserInfo info;
        //[2] ����ü�� ���� ������ �ʱ�ȭ
        info.name = "ȫ�浿";
        info.age = 20;
        //[3] ����ü ���
        //printuserinfo(info.name, info.age);
        printuserinfo(info);

        //[1] ����ü�� �迭 ���� ����, �迭�� ��Ҽ�(ũ��) ����
        UserInfo[] userInfos = new UserInfo[2];
        //[2] ����ü �迭 �ʱ�ȭ
        userInfos[0].name = "��λ�";
        userInfos[0].age = 22;
        userInfos[1].name = "�Ӳ���";
        userInfos[1].age = 33;
        //[3] ����ü �迭 ���
        for(int i = 0; i < userInfos.Length; i++)
        {
            //printuserinfo(userInfos[i].name, userInfos[i].age);
            printuserinfo(userInfos[i]);
        }
    }

    // ���� ����� ����ϴ� �Լ�.
    void printuserinfo(string name, int age)
    {
        Debug.Log($"���̸� : {name}, ������: {age}");

    }

    void printuserinfo(UserInfo userinfo) // ����ü
    {
        Debug.Log($"���̸� : {userinfo.name}, ������: {userinfo.age}");
    }

}
