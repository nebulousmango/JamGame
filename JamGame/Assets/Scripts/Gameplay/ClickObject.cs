using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickObject : MonoBehaviour, IPointerDownHandler, IPointerExitHandler, IPointerEnterHandler
{
    [SerializeField] GameObject[] TurnThisOn;
    [SerializeField] GameObject[] TurnThisOff;
    private bool MouseHover;

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

    void Update()
    {
        if (MouseHover) this.OnPointerOver();
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
    }
}