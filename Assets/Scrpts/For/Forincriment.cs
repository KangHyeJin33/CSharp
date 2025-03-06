using UnityEngine;

public class Forincriment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 증감식.
        // 0부터 10까지 카운팅 하는데 2씩 증가 하면서 출력.
        // 0, 2, 4, 6, 8, 10

        for (int i = 0; i < 11; i = i + 2)
        {
            Debug.Log($"i : {i}");
            //Debug.Log(i);
        }
    }
}
