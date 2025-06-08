using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class AudioManager : MonoBehaviour
{
    // Attached to AudioManager object in 01 StartScene.

    public SoundData[] Level1SoundsData;
    public SoundData[] Level2SoundsData;
    public SoundData[] Level3SoundsData;
    public SoundData[] UISoundsData;

    private void Awake()
    {
        CreateSources();
    }

    void CreateSources()
    {
        foreach (SoundData soundData in Level1SoundsData)
        {
            AudioSource src = gameObject.AddComponent<AudioSource>();
            soundData.AudioSource = src;
            soundData.AudioSource.clip = soundData.AudioClip;
            soundData.AudioSource.volume = soundData.F_Volume;
            soundData.AudioSource.playOnAwake = soundData.B_PlayOnAwake;
            soundData.AudioSource.loop = soundData.B_Loop;
        }
        foreach (SoundData soundData in Level2SoundsData)
        {
            AudioSource src = gameObject.AddComponent<AudioSource>();
            soundData.AudioSource = src;
            soundData.AudioSource.clip = soundData.AudioClip;
            soundData.AudioSource.volume = soundData.F_Volume;
            soundData.AudioSource.playOnAwake = soundData.B_PlayOnAwake;
            soundData.AudioSource.loop = soundData.B_Loop;
        }
        foreach (SoundData soundData in Level3SoundsData)
        {
            AudioSource src = gameObject.AddComponent<AudioSource>();
            soundData.AudioSource = src;
            soundData.AudioSource.clip = soundData.AudioClip;
            soundData.AudioSource.volume = soundData.F_Volume;
            soundData.AudioSource.playOnAwake = soundData.B_PlayOnAwake;
            soundData.AudioSource.loop = soundData.B_Loop;
        }
        foreach (SoundData soundData in UISoundsData)
        {
            AudioSource src = gameObject.AddComponent<AudioSource>();
            soundData.AudioSource = src;
            soundData.AudioSource.clip = soundData.AudioClip;
            soundData.AudioSource.volume = soundData.F_Volume;
            soundData.AudioSource.playOnAwake = soundData.B_PlayOnAwake;
            soundData.AudioSource.loop = soundData.B_Loop;
        }
    }

    public void PlaySound(string name)
    {
        foreach (SoundData sd in Level1SoundsData)
        {
            if (sd.S_Name == name) sd.AudioSource.Play();
        }
        foreach (SoundData sd in Level2SoundsData)
        {
            if (sd.S_Name == name) sd.AudioSource.Play();
        }
        foreach (SoundData sd in Level3SoundsData)
        {
            if (sd.S_Name == name) sd.AudioSource.Play();
        }
        foreach (SoundData sd in UISoundsData)
        {
            if (sd.S_Name == name) sd.AudioSource.Play();
        }
    }

    public void StopSound(string name)
    {
        foreach (SoundData sd in Level1SoundsData)
        {
            if (sd.S_Name == name) sd.AudioSource.Stop();
        }
        foreach (SoundData sd in Level2SoundsData)
        {
            if (sd.S_Name == name) sd.AudioSource.Stop();
        }
        foreach (SoundData sd in Level3SoundsData)
        {
            if (sd.S_Name == name) sd.AudioSource.Stop();
        }
        foreach (SoundData sd in UISoundsData)
        {
            if (sd.S_Name == name) sd.AudioSource.Stop();
        }
    }
}
