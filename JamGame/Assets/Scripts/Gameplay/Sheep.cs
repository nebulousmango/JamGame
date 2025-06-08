using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    // Attached to Item (5) object in 02 Level01.

    public int SheepCount;
    [SerializeField] GameObject[] TurnThisOn;

    private void Update()
    {
        if (SheepCount == 5)
        {
            for (int i = 0; i < TurnThisOn.Length; i++)
            {
                TurnThisOn[i].SetActive(true);
                SheepCount = 0;
            }
        }
    }
}
