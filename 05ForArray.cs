using UnityEngine;

public class ForArray : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}
