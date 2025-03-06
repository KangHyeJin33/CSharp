using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("¿À´Ã ³¯¾¾´Â ¾î¶²°¡¿ä? (¸¼À½, Èå¸², ºñ, ´«)");

        string weather = "Èå¸²";

        /* switch(weather)
        {
            case "¸¼À½":
                Debug.Log($"¿À´Ã ³¯¾¾´Â {weather}ÀÔ´Ï´Ù.");
                break;
            case "Èå¸²":
                Debug.Log($"¿À´Ã ³¯¾¾´Â {weather}ÀÔ´Ï´Ù.");
                break;
            case "ºñ":
                Debug.Log($"¿À´Ã ³¯¾¾´Â {weather}ÀÔ´Ï´Ù.");
                break;
            case "´«":
                Debug.Log($"¿À´Ã ³¯¾¾´Â {weather}ÀÔ´Ï´Ù.");
                break;
            default:
                Debug.Log("Àß ¸ø ÀÔ·ÂÇÏ¼Ì½À´Ï´Ù. Á¾·á");
                break;
        }*/

        // if¹®
        if (weather == "¸¼À½")
        {
            Debug.Log($"¿À´Ã ³¯¾¾´Â {weather}ÀÔ´Ï´Ù.");
        }
        else if (weather == "Èå¸²")
        {
            Debug.Log($"¿À´Ã ³¯¾¾´Â {weather}ÀÔ´Ï´Ù.");
        }
        else if (weather == "ºñ")
        {
            Debug.Log($"¿À´Ã ³¯¾¾´Â {weather}ÀÔ´Ï´Ù.");
        }
        else if (weather == "´«")
        {
            Debug.Log($"¿À´Ã ³¯¾¾´Â {weather}ÀÔ´Ï´Ù.");
        }
        else
        {
            Debug.Log("Àß ¸ø ÀÔ·ÂÇÏ¼Ì½À´Ï´Ù. Á¾·á");

        }

    }
}
