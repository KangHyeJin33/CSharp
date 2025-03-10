using UnityEngine;

// 가변형배열 : 배열의 길이가 가변이다. ex.int[][] 변수이름. 
public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2차원 배열 선언 : 첫 번째 요소수(크기)만 생성.
        int[][] intArray = new int[2][];

        //[2] 2차원 배열 (두 번째) 요소수(크기) 각각 따로 생성.
        intArray[0] = new int[3]; // 첫번째 행[0]은 int형의 열을 [3]개를 갖는다. 
        intArray[1] = new int[2]; // 두번째 행[1]은 int형의 열을 [2]개를 갖는다. 
        intArray[0] = new int[3] { 1, 2, 3 };
        intArray[1] = new int[2] { 4, 5 };


        // 배열의 길이.
        Debug.Log($"배열의 길이 : {intArray.Length}"); // 2

        //[4] 2차원 배열 사용하기.
        for(int i = 0; i < intArray.Length; i++)
        {
            for(int j = 0; j < intArray[i].Length; j++) // 'j < 3' 없는값을 찍어야 되므로, 안쓴다.
            {
                Debug.Log(intArray[i][j]);

            }
            Debug.Log("==================================");
        }
    }
}
