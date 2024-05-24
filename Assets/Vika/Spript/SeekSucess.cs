using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekSucess : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {

        Hint.SetActive(false);
        text.SetActive(false);
    }

    public GameObject Effect;
    public GameObject Hint;
    public GameObject text;
    public GameObject key;
    public GameObject door;
    public bool created = false;
    public AudioSource audio;
    public AudioSource audio2;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Hint.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                audio2.Play();
                Effect.GetComponent<ParticleSystem>().Play();
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
        }
    }
}
        