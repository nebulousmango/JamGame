using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panels : MonoBehaviour
{
    public int PanelCount;
    [SerializeField] GameObject[] TurnThisOn;
    public bool SceneEnded;
    public string CurrentScene;
    public string NextScene;

    private void Update()
    {
        if (PanelCount == 10)
        {
            SceneEnded = true;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (SceneEnded)
                {
                    SceneManager.LoadScene("03 Level02");
                }
            }
        }
    }
}
