using UnityEngine;

public class SwitchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1번, 2번, 3번, 4번 답을 선택했습니다. 출력.
        // 그 외 값을 선택하면, "잘 못 선택했습니다." 출력.

        int answer = 5;

        /* switch(answer)
        {
            case 1:
                Debug.Log($"{answer}번 답을 선택했습니다.");
                break;
            case 2:
                Debug.Log($"{answer}번 답을 선택했습니다.");
                break;
            case 3:
                Debug.Log($"{answer}번 답을 선택했습니다.");
                break;
            case 4:
                Debug.Log($"{answer}번 답을 선택했습니다.");
                break;
            default:
                Debug.Log("잘 못 선택했습니다.");
                break;
        }*/
     
        // if문
        if(answer == 1)
        {
            Debug.Log($"{answer}번 답을 선택했습니다.");
        }
        else if(answer == 2)
        {
            Debug.Log($"{answer}번 답을 선택했습니다.");
        }
        else if(answer == 3)
        {
            Debug.Log($"{answer}번 답을 선택했습니다.");
        }
        else if(answer == 4)
        {
            Debug.Log($"{answer}번 답을 선택했습니다.");
        }
        else
        {
            Debug.Log("잘 못 선택했습니다.");
        }
    }
}
