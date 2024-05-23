using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public FireballCaster player2;
    public bool OnZone = false;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<FireballCaster>();
        if (player != null)
        {
            player2.enabled = true;
            OnZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        player2.enabled = false;
        OnZone = false;
    }
}
