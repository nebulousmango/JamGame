using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollectSheep : MonoBehaviour, IPointerDownHandler
{
    // Attached to Sheep Int objects in 02 Level01.

    public void OnPointerDown(PointerEventData eventData)
    {
        FindObjectOfType<Sheep>().SheepCount++;
    }
}
