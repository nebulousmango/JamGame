using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeScene : MonoBehaviour
{
    public Image FadeImage;
    public float FadeTime = 1f;

    void Start()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeOut(sceneName));
    }

    IEnumerator FadeIn()
    {
        float t = FadeTime;
        Color color = FadeImage.color;
        while (t > 0)
        {
            t -= Time.deltaTime;
            color.a = t / FadeTime;
            FadeImage.color = color;
            yield return null;
        }
    }

    IEnumerator FadeOut(string sceneName)
    {
        float t = 0;
        Color color = FadeImage.color;
        while (t < FadeTime)
        {
            t += Time.deltaTime;
            color.a = t / FadeTime;
            FadeImage.color = color;
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }
}
