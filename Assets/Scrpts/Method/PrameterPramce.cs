using UnityEngine;

namespace Methood
{
    public class PrameterPramce : MonoBehaviour
    {
        // [4] 가변형 번달 방법
        // params : 가변(고정x) 길이 매개 변수
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(SumAll(3, 5));
            Debug.Log(SumAll(3, 5, 7));
            Debug.Log(SumAll(3, 5, 7, 9)); // 3, 5, 7, 9 : 정수'들'
        }

        //매개변수로 입력받은 정수들의 합을 구하는 메서드. 입력받은 정수만큼 길이가 늘어남.
        int SumAll(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
