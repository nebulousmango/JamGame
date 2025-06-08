using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    public string CurrentScene;
    public string LevelLoad;
    public int PlayerPrefsLevelsCompletedInt;

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
        if (CurrentScene == "01 StartScene")
        {
            PlayerPrefsLevelsCompletedInt = PlayerPrefs.GetInt("LevelsCompletedInt");
            if (PlayerPrefsLevelsCompletedInt == 1) LevelLoad = "03 Level02";
            if (PlayerPrefsLevelsCompletedInt == 2) LevelLoad = "04 Level03";
        }
        if (CurrentScene == "02 Level01")
        {
            PlayerPrefs.SetInt("LevelsCompletedInt", 0);
            PlayerPrefs.Save();
        }
        if (CurrentScene == "03 Level02")
        {
            PlayerPrefs.SetInt("LevelsCompletedInt", 1);
            PlayerPrefs.Save();
            LevelLoad = "03 Level02";
        }
        if (CurrentScene == "04 Level03")
        {
            PlayerPrefs.SetInt("LevelsCompletedInt", 2);
            PlayerPrefs.Save();
            LevelLoad = "04 Level03";
        }
    }
}
