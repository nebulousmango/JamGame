using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class FinalObject : MonoBehaviour, IPointerDownHandler
{
    // Attached to final Int objects in Level scenes.

    public bool SceneEnded;
    public string CurrentScene;
    public string NextScene;
    [SerializeField] GameObject[] TurnThisOn;

    public void OnPointerDown(PointerEventData eventData)
    {
        SceneEnded = true;
        for (int i = 0; i < TurnThisOn.Length; i++)
        {
            TurnThisOn[i].SetActive(true);
        }
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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SceneEnded)
            {
                SceneManager.LoadScene(NextScene);
            }
        }
    }
}