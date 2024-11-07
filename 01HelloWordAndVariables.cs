using UnityEngine;

public class HelloWordAndVariables : MonoBehaviour
{
    // Integer para guardar numeros enteros sin decimales hasta 2,147,483,647 y en negatvivo (4 bytes)
    int entero = 20;

    // Float para guardar numeros con decimales hasta 7 digitos (4 bytes)
    float flotante = 20.5f;

    // Double para guardar numeros con decimales hasta 15 digitos (8 bytes)
    double doble = 20.5;

    // String para guardar texto
    string texto = "Hola Mundo";

    // Boolean para guardar valores de verdadero o falso
    bool booleano = true;

    // Char para guardar un solo caracter
    char caracter = 'a';

    void Start()
    {
        Debug.Log("Entero: " + entero + " Flotante: " + flotante + " Doble: " + doble + " Texto: " + texto + " Booleano: " + booleano + " Caracter: " + caracter);
    }
}
