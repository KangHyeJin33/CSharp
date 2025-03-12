using UnityEngine;

//로또 번호 생성기.
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random random = new System.Random();

        //배열 변수 선언 및 요소수 생성
        int[] numbers = new int[6];

        //
        int number = 0; //랜덤값을 저장하는 변수.
        bool flag = false; //중복 검사해서 중복이면 true, 아니면 false.

        for (int i = 0; i < 6; i++)
        {
            number = random.Next(1, 46); // 1~46까지의 랜덤값을 받아 옴.
            //numbers[i] = random.Next(1, 46); // 숫자가 하나 씩 1~ 46까지의 숫자를 랜덤으로 numbers[i]에 들어오면 저장됨.
            //Debug.Log(random.Next(1, 45));

            //중복 체크 - number와 먼저 뽑힌 로또번호와 비교해서 검사
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
            
            if(flag == false) //중복이 아니면
            {
                numbers[i] = number; // nambers[0] -> +1 -> number값을 대입했을 때,
            }
            else //중복이면 다시 계산하기 위해 인덱스를 조정한다
            {
                i--; //numbers[0]의 값이 number값과 같으면 numvber[0]
            }
            
        }
        for(int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}

/*
number[0] : x (비교할 값이 없음)
number[1] : [0]
number[2] : [0], [1]
number[3] : [0], [1], [2]
number[4] : [0], [1], [2], [3]
number[5] : [0], [1], [2], [3], [4]

 */
/*
[Q]
로또 번호 생성기 만들기.
[1] 6개 번호
[2] 1~45 사이의 랜덤 번호
[3] 중복된 숫자가 나오면 안된다

//
[1], [2] 먼저 구현.

[OutPut] - 조건에 맞는 번호 6개 출력
1
2
3
4
5
6
*/