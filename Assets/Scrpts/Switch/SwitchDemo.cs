using UnityEngine;

public class SwitchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1��, 2��, 3��, 4�� ���� �����߽��ϴ�. ���.
        // �� �� ���� �����ϸ�, "�� �� �����߽��ϴ�." ���.

        int answer = 5;

        /* switch(answer)
        {
            case 1:
                Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
                break;
            case 2:
                Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
                break;
            case 3:
                Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
                break;
            case 4:
                Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
                break;
            default:
                Debug.Log("�� �� �����߽��ϴ�.");
                break;
        }*/
     
        // if��
        if(answer == 1)
        {
            Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
        }
        else if(answer == 2)
        {
            Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
        }
        else if(answer == 3)
        {
            Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
        }
        else if(answer == 4)
        {
            Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
        }
        else
        {
            Debug.Log("�� �� �����߽��ϴ�.");
        }
    }
}
