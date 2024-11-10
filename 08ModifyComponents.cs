using UnityEngine;

public class ModifyComponents : MonoBehaviour
{
    void Start()
    {
        gameObject.AddComponent<Rigidbody>();

        Debug.Log("name: " + gameObject.name);

        transform.position = new Vector3(0, 8, 7);

    }

}
