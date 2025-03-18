using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] kor = { 90, 65, 78, 50, 95 };

        List<int> score = kor.Where(x => x <= 70 || x <= 95).ToList();

        double average = score.Average();
        Debug.Log($"국어 점수 평균 : {average:#.##}");
    }
}

/*
[Q]
입력데이터 {90, 65, 78, 50, 95}
국어점수 중 70점 이상이고 95점 이하인 점수들의 평균을 구하라

[output] - 소수점이하 2자리까지
평균 점수 : average

 */
