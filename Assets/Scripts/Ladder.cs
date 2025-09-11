using System;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Player"))
        {
            trig.gameObject.GetComponent<PlayerController>().SetOnLadder(true, 0f);
        }
    }

    private void OnTriggerExit2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Player"))
        {
            trig.gameObject.GetComponent<PlayerController>().SetOnLadder(false, 1f);
        }
    }
}
