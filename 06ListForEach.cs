using UnityEngine;
using System.Collections.Generic;

public class ListForEach : MonoBehaviour
{

    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

    void Start()
    {
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
    }

}
