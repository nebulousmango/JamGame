using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CleanPanels : MonoBehaviour, IPointerDownHandler
{
    // Attached to Panel Int objects in 02 Level01.

    public void OnPointerDown(PointerEventData eventData)
    {
        FindObjectOfType<Panels>().PanelCount++;
    }
}
