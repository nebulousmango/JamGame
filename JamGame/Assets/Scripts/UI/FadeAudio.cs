using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeAudio : MonoBehaviour
{
    public AudioSource currentAudio;
    public float fadeDuration = 1.5f;

    public void LoadSceneWithFade(string sceneName)
    {
        StartCoroutine(FadeAndLoad(sceneName));
    }

    IEnumerator FadeAndLoad(string sceneName)
    {
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            currentAudio.volume = 1 - t / fadeDuration;
            yield return null;
        }

        currentAudio.volume = 0;
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
}
