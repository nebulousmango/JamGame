using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverObject : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    private bool MouseHover;
    [SerializeField] GameObject[] TurnThisOn;

    void Update()
    {
        if (MouseHover) this.OnPointerOver();
        if (MouseHover==false) this.OnPointerNotOver();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        MouseHover = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        MouseHover = false;
    }

    private void OnPointerOver()
    {
        for (int i = 0; i < TurnThisOn.Length; i++)
        {
            TurnThisOn[i].SetActive(true);
        }
    }
    private void OnPointerNotOver()
    {
        for (int i = 0; i < TurnThisOn.Length; i++)
        {
            TurnThisOn[i].SetActive(false);
        }
    }
}
