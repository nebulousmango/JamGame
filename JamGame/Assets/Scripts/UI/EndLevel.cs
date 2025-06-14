using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour, IPointerDownHandler
{
    public string CurrentScene;
    public string NextScene;

    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene(NextScene);
    }

    private void Start()
    {
        CurrentScene = SceneManager.GetActiveScene().name;

        if (CurrentScene == "02 Level01")
        {
            NextScene = "03 Level02";
        }
        if (CurrentScene == "03 Level02")
        {
            NextScene = "04 Level03";
        }
        if (CurrentScene == "04 Level03")
        {
            NextScene = "05 EndCreditsScene";
        }
        if (CurrentScene == "05 EndCreditsScene")
        {
            NextScene = "01 StartScene";
        }
    }
}
