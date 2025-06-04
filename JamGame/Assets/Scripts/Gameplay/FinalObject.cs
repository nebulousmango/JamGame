using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class FinalObject : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject TurnThisOn;
    [SerializeField] Image TurnThisOff;

    public Image FadePanel;
    public bool SceneEnded;
    public string CurrentScene;
    public string NextScene;

    public void OnPointerDown(PointerEventData eventData)
    {
        SceneEnded = true;
        TurnThisOn.SetActive(true);
        TurnThisOff.enabled = false;
        if (CurrentScene == "07 EndCreditsScene")
        {
            FadePanel.enabled = true;
            FindObjectOfType<FadeScene>().FadeToScene(NextScene);
        }
    }

    private void Start()
    {
        CurrentScene = SceneManager.GetActiveScene().name;
        FadePanel = GameObject.Find("FadePanel").GetComponent<UnityEngine.UI.Image>();

        if (CurrentScene == "04 Level01")
        {
            NextScene = "05 Level02";
        }
        if (CurrentScene == "05 Level02")
        {
            NextScene = "06 Level03";
        }
        if (CurrentScene == "06 Level03")
        {
            NextScene = "07 EndCreditsScene";
        }
        if (CurrentScene == "07 EndCreditsScene")
        {
            NextScene = "01 StartScene";
        }
    }

    private void Update()
    {
        if(SceneEnded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FadePanel.enabled = true;
                FindObjectOfType<FadeScene>().FadeToScene(NextScene);
            }
        }
    }
}