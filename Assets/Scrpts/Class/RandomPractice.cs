using UnityEngine;

//�ζ� ��ȣ ������.
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random random = new System.Random();

        //�迭 ���� ���� �� ��Ҽ� ����
        int[] numbers = new int[6];

        //
        int number = 0; //�������� �����ϴ� ����.
        bool flag = false; //�ߺ� �˻��ؼ� �ߺ��̸� true, �ƴϸ� false.

        for (int i = 0; i < 6; i++)
        {
            number = random.Next(1, 46); // 1~46������ �������� �޾� ��.
            //numbers[i] = random.Next(1, 46); // ���ڰ� �ϳ� �� 1~ 46������ ���ڸ� �������� numbers[i]�� ������ �����.
            //Debug.Log(random.Next(1, 45));

            //�ߺ� üũ - number�� ���� ���� �ζǹ�ȣ�� ���ؼ� �˻�
            flag = false;
            if(i > 0)
            {
                for(int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }    
            }
            
            if(flag == false) //�ߺ��� �ƴϸ�
            {
                numbers[i] = number; // nambers[0] -> +1 -> number���� �������� ��,
            }
            else //�ߺ��̸� �ٽ� ����ϱ� ���� �ε����� �����Ѵ�
            {
                i--; //numbers[0]�� ���� number���� ������ numvber[0]
            }
            
        }
        for(int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}

/*
number[0] : x (���� ���� ����)
number[1] : [0]
number[2] : [0], [1]
number[3] : [0], [1], [2]
number[4] : [0], [1], [2], [3]
number[5] : [0], [1], [2], [3], [4]

 */
/*
[Q]
�ζ� ��ȣ ������ �����.
[1] 6�� ��ȣ
[2] 1~45 ������ ���� ��ȣ
[3] �ߺ��� ���ڰ� ������ �ȵȴ�

//
[1], [2] ���� ����.

[OutPut] - ���ǿ� �´� ��ȣ 6�� ���
1
2
3
4
5
6
*/