using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("���� ������ �����? (����, �帲, ��, ��)");

        string weather = "�帲";

        /* switch(weather)
        {
            case "����":
                Debug.Log($"���� ������ {weather}�Դϴ�.");
                break;
            case "�帲":
                Debug.Log($"���� ������ {weather}�Դϴ�.");
                break;
            case "��":
                Debug.Log($"���� ������ {weather}�Դϴ�.");
                break;
            case "��":
                Debug.Log($"���� ������ {weather}�Դϴ�.");
                break;
            default:
                Debug.Log("�� �� �Է��ϼ̽��ϴ�. ����");
                break;
        }*/

        // if��
        if (weather == "����")
        {
            Debug.Log($"���� ������ {weather}�Դϴ�.");
        }
        else if (weather == "�帲")
        {
            Debug.Log($"���� ������ {weather}�Դϴ�.");
        }
        else if (weather == "��")
        {
            Debug.Log($"���� ������ {weather}�Դϴ�.");
        }
        else if (weather == "��")
        {
            Debug.Log($"���� ������ {weather}�Դϴ�.");
        }
        else
        {
            Debug.Log("�� �� �Է��ϼ̽��ϴ�. ����");

        }

    }
}
