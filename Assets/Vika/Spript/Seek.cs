using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seek : MonoBehaviour
{
    public GameObject Effect;
    public GameObject Hint;
    public GameObject text;
    public AudioSource audio;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        { 
            Hint.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {


                Effect.GetComponent<ParticleSystem>().Play();
                text.SetActive(true);
                audio.Play();

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
            Hint.SetActive(false);
        text.SetActive(false);
    }
}
