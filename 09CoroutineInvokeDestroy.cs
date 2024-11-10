using System.Collections;
using UnityEngine;

public class CoroutineInvokeDestroy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Coroutine(2f));
        Invoke("Disparar", 3f);
    }

    void Update()
    {
        
    }

    IEnumerator Coroutine(float time)
    {
        Debug.Log("Hola");

        yield return new WaitForSeconds(time);
    
        Debug.Log("Buenos días");
        
        yield return new WaitForSeconds(time);

        Debug.Log("Buenas tardes");

        Destroy(gameObject);

    }

    void Disparar()
    {
        Debug.Log("Disparando");
    }
}
