using UnityEngine;

public class TypesOfOperations : MonoBehaviour
{
    int a = 10;
    int b = 5;
    

    void Start()
    {
        // sumar
        Debug.Log(a + b); // 15

        // restar
        Debug.Log(a - b); // 5

        // multiplicar
        Debug.Log(a * b); // 50

        // dividir
        Debug.Log(a / b); // 2

        // modulo

        Debug.Log(a % b); // 0

        // incremento
        a++;
        Debug.Log(a); // 11

        // decremento
        b--;
        Debug.Log(b); // 4
    }

}
