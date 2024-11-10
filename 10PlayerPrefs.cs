using UnityEngine;

public class PlayerPrefsExample : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("Level", 100);
        PlayerPrefs.SetString("PlayerName", "Juan");

        Debug.Log(PlayerPrefs.GetInt("Level"));
        Debug.Log(PlayerPrefs.GetString("PlayerName"));

    }

}
