using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MusicManager : MonoBehaviour
{
    public float FadeDuration = 0.5f;
    public string CurrentScene;

    void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        CurrentScene = SceneManager.GetActiveScene().name;
        if (CurrentScene == "00 SplashScene")
        {
            FindObjectOfType<AudioManager>().StopSound("Level1Music");
            FindObjectOfType<AudioManager>().StopSound("Level2Music");
            FindObjectOfType<AudioManager>().StopSound("Level3Music");
            FindObjectOfType<AudioManager>().PlaySound("SplashMusic");
        }
        if (CurrentScene== "04 Level01")
        {
            FindObjectOfType<AudioManager>().StopSound("SplashMusic");
            FindObjectOfType<AudioManager>().PlaySound("Level1Music");
        }
        if (CurrentScene == "05 Level02")
        {
            FindObjectOfType<AudioManager>().StopSound("Level1Music");
            FindObjectOfType<AudioManager>().StopSound("SplashMusic");
            FindObjectOfType<AudioManager>().PlaySound("Level2Music");
        }
        if (CurrentScene == "06 Level03")
        {
            FindObjectOfType<AudioManager>().StopSound("Level2Music");
            FindObjectOfType<AudioManager>().StopSound("SplashMusic");
            FindObjectOfType<AudioManager>().PlaySound("Level3Music");
        }
    }
}
