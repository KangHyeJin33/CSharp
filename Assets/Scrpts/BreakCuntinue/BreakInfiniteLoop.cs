using Unity.VisualScripting;
using UnityEngine;

//break�� ���ѷ��� ���� ������.
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ���ѷ��� - ���� �ݺ�
        /*for(; ;) // ���� �ݺ�
        {

        }*/

        /*while(true) // �� �̸�, ���� �ݺ�.
        {

        }*/

        int number = 0;

        //number�� 5�̻��̸�, while�� ����.
        while(true) // ���ѷ���
        {
            //�ݺ� ���๮.
            Debug.Log(number);

            number++;
            if(number >=5)
            {
                break;
            }
    
        }

    }
}
