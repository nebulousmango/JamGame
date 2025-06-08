using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScenePanels : MonoBehaviour
{
    public GameObject ContinueGamePanel;
    public GameObject NewGamePanel;
    public GameObject Splash1;
    public GameObject Splash2;
    public GameObject Splash3;
    public int PlayerPrefsLevelsCompletedInt;
    public string LevelLoad;

    private void Start()
    {
        PlayerPrefsLevelsCompletedInt = FindObjectOfType<SaveManager>().PlayerPrefsLevelsCompletedInt;
        LevelLoad = FindObjectOfType<SaveManager>().LevelLoad;

        if (PlayerPrefsLevelsCompletedInt == 0)
        {
            ContinueGamePanel.SetActive(false);
            NewGamePanel.SetActive(true);
            Splash1.SetActive(true);
        }
        if (PlayerPrefsLevelsCompletedInt == 1)
        {
            NewGamePanel.SetActive(false);
            ContinueGamePanel.SetActive(true);
            FindObjectOfType<ButtonManager>().S_LevelLoad = LevelLoad;
            Splash2.SetActive(true);
        }
        if (PlayerPrefsLevelsCompletedInt == 2)
        {
            NewGamePanel.SetActive(false);
            ContinueGamePanel.SetActive(true);
            FindObjectOfType<ButtonManager>().S_LevelLoad = LevelLoad;
            Splash3.SetActive(true);
        }
    }
}
