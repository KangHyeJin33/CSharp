using UnityEngine;

public class IfslsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string medal = ""; // �� ������ ���� �ʱ�ȭ.

        if (score >= 90)
        {
            medal = "�ݸ޴�";
            //Debug.Log("�ݸ޴��� �����Ͽ����ϴ�.");
        }
        else // 0~89���϶�
        {
            if (score >= 80)
            {
                medal = "���޴�";
                //Debug.Log("���޴��� �����Ͽ����ϴ�.");
            }
            else // 0~79���϶�
            { 
                if(score >=70)
                {
                    medal = "���޴�";
                }
                else // 0~69���϶�,
                {
                    medal = "��޴�";
                }
            }

    }
        Debug.Log($"{medal}�� �����Ͽ����ϴ�.");
  }
}
/*
[Q]
score�� 90�̻��̸� �ݸ޴� ���, 80�̻��̸� ���޴� ���,
70�̻��̸� ���޴� ���, �� �� �������� ��޴� ���.
score�� 85��.

[output]
()�޴��� �����Ͽ����ϴ�.
 */