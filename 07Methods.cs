using UnityEngine;

public class Methods : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Response("Ángel"));
        Debug.Log(Response("Juan"));
    }

    string Response(string name)
    {
        if (name == "Ángel")
        {
            return "Hello Developer!";
        }
        else
        {
            return "Hello " + name + "!";
        }
    }

}
