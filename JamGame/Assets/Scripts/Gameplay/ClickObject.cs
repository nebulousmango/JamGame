using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickObject : MonoBehaviour, IPointerDownHandler
{
    // Attached to Int objects in Level scenes.

    [SerializeField] GameObject[] TurnThisOn;
    [SerializeField] GameObject[] TurnThisOff;

    public void OnPointerDown(PointerEventData eventData)
    {
        for (int i = 0; i < TurnThisOn.Length; i++)
        {
            TurnThisOn[i].SetActive(true);
        }
        for (int i = 0; i < TurnThisOff.Length; i++)
        {
            TurnThisOff[i].SetActive(false);
        }
    }
}