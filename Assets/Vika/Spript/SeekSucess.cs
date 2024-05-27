using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekSucess : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {

        Hint.SetActive(false);
        text.SetActive(false);
        Hint2.SetActive(false);
    }

    public GameObject Effect;
    public GameObject Hint;
    public GameObject text;
    public GameObject key;
    public GameObject door;
    public GameObject Hint2;
    public bool created = false;
    public AudioSource audio;
    public AudioSource audio2;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            
            if (Input.GetKey(KeyCode.E))
            {
                audio2.Play();
                Effect.GetComponent<ParticleSystem>().Play();
                Hint2.SetActive(true);
                Hint.SetActive(false);
                if (created == false)
                {
                    text.SetActive(true);
                    Instantiate(key);
                    created = true;
                    door.GetComponent<Collider>().enabled = false;
                    door.transform.Rotate(0, 90, 0);
                    audio.Play();

                }

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
}
        