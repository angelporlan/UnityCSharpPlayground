using UnityEngine;

public class IfConditions : MonoBehaviour
{

    int vida = 100;

    void Start()
    {
        if (vida > 0 && vida <= 100)
        {
            Debug.Log("El jugador esta vivo");
        } else if (vida > 100)
        {
            Debug.Log("El jugador tiene escudo");
        }
        else
        {
            Debug.Log("El jugador esta muerto");
        }
    }

}
