using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScenePanels : MonoBehaviour
{
    public GameObject ContinueGamePanel;
    public GameObject NewGamePanel;
    private SaveManager SaveManager;
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
        }
        if (PlayerPrefsLevelsCompletedInt == 1 | PlayerPrefsLevelsCompletedInt == 2)
        {
            NewGamePanel.SetActive(false);
            ContinueGamePanel.SetActive(true);
            FindObjectOfType<ButtonManager>().S_LevelLoad = LevelLoad;
        }
    }
}
