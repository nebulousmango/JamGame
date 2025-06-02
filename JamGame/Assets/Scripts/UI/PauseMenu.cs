using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Attached to Canvas object in Level scenes.

    [SerializeField] private GameObject Go_PauseMenuUI;
    static bool GameIsPaused = false;

    private void Start()
    {
        GameIsPaused = false;
        Go_PauseMenuUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        FindObjectOfType<AudioManager>().PlaySound("Button");
        Go_PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    void Resume()
    {
        FindObjectOfType<AudioManager>().PlaySound("Button");
        Go_PauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1;
    }

    public void ChangePauseBool()
    {
        GameIsPaused = false;
    }
}
