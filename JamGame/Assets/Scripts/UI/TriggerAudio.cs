using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TriggerAudio : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private string ObjectSFX;
    [SerializeField] private string StopObjectSFX;

    public void OnPointerDown(PointerEventData eventData)
    {
        FindObjectOfType<AudioManager>().PlaySound(ObjectSFX);
        FindObjectOfType<AudioManager>().StopSound(StopObjectSFX);
    }
}
