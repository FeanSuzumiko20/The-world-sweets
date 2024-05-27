using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Shelf : MonoBehaviour
{   public GameObject text;
    public GameObject Hint;
    public GameObject Hint2;
    public AudioSource audio;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Hint.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                audio.Play();
                text.SetActive(true);
                Hint.SetActive(false);

            }
            if (Input.GetKey(KeyCode.F) && text.activeSelf == true)
            {
                text.SetActive(false);
                Hint.SetActive(true);
                Hint2.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Hint2.SetActive(false);
        Hint.SetActive(false);
        text.SetActive(false);
    }
}

