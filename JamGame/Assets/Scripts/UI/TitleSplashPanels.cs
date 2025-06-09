using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSplashPanels : MonoBehaviour
{
    public GameObject Splash1;
    public GameObject Splash2;
    public GameObject Splash3;
    public int PlayerPrefsLevelsCompletedInt;

    void Start()
    {
        PlayerPrefsLevelsCompletedInt = FindObjectOfType<SaveManager>().PlayerPrefsLevelsCompletedInt;

        if (PlayerPrefsLevelsCompletedInt == 0)
        {
            Splash1.SetActive(true);
        }
        if (PlayerPrefsLevelsCompletedInt == 1)
        {
            Splash2.SetActive(true);
        }
        if (PlayerPrefsLevelsCompletedInt == 2)
        {
            Splash3.SetActive(true);
        }
        if (PlayerPrefsLevelsCompletedInt == 3)
        {
            Splash1.SetActive(true);
        }
    }
}
