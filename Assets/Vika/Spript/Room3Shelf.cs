using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Shelf : MonoBehaviour
{   public GameObject text;
    public GameObject Hint;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Hint.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                text.SetActive(true);

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Hint.SetActive(false);
        text.SetActive(false);
    }
}

