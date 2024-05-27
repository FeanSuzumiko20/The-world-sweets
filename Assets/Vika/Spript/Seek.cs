using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seek : MonoBehaviour
{
    public GameObject Effect;
    public GameObject Hint;
    public GameObject Hint2;
    public GameObject text;
    public AudioSource audio;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        { 
           
            if (Input.GetKey(KeyCode.E))
            {
                Effect.GetComponent<ParticleSystem>().Play();
                text.SetActive(true);
                audio.Play();
                Hint.SetActive(false);
                Hint2.SetActive(true);
            }
            if (Input.GetKey(KeyCode.F) && text.activeSelf == true)
            {
                text.SetActive(false);
                Hint.SetActive(true);
                Hint2.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Hint.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Hint2.SetActive(false);
        Hint.SetActive(false);
        text.SetActive(false);
    }
}
