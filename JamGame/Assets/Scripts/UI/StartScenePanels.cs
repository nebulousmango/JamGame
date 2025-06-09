using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScenePanels : MonoBehaviour
{
    // Attached to Canvas object in 01 StartScene.

    public GameObject MainPanels;
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
            MainPanels.SetActive(true);
            NewGamePanel.SetActive(true);
            ContinueGamePanel.SetActive(false);
            Splash1.SetActive(true);
        }
        if (PlayerPrefsLevelsCompletedInt == 1)
        {
            MainPanels.SetActive(true);
            NewGamePanel.SetActive(false);
            ContinueGamePanel.SetActive(true);
            FindObjectOfType<ButtonManager>().S_LevelLoad = LevelLoad;
            Splash2.SetActive(true);
        }
        if (PlayerPrefsLevelsCompletedInt == 2)
        {
            MainPanels.SetActive(true);
            NewGamePanel.SetActive(false);
            ContinueGamePanel.SetActive(true);
            FindObjectOfType<ButtonManager>().S_LevelLoad = LevelLoad;
            Splash3.SetActive(true);
        }
        if (PlayerPrefsLevelsCompletedInt == 3)
        {
            MainPanels.SetActive(true);
            NewGamePanel.SetActive(true);
            ContinueGamePanel.SetActive(false);
            FindObjectOfType<ButtonManager>().S_LevelLoad = LevelLoad;
            Splash1.SetActive(true);
        }
    }
}
