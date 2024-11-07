using UnityEngine;

public class SwitchWhile : MonoBehaviour
{
    int condition = 1;
    void Start()
    {
        switch (condition)
        {
            case 1:
                Debug.Log("Case 1");
                break;
            case 2:
                Debug.Log("Case 2");
                break;
            case 3:
                Debug.Log("Case 3");
                break;
            default:
                Debug.Log("Default");
                break;
        }

        while (condition < 6)
        {
            Debug.Log("While " + condition);
            condition++;
        }
    }

}
