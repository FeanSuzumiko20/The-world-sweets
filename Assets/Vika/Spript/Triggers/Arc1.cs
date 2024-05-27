using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arc1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Hint;
    public GameObject Hint2;
    public GameObject text;
    public bool on;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
           
            if (Input.GetKey(KeyCode.E))
            {
                text.SetActive(true);
                Hint.SetActive(false);
                on = true;
                Hint2.SetActive(true);
            }
            if (Input.GetKey(KeyCode.F) && on == true)
            {
                text.SetActive(false);
                Hint.SetActive(true);
                Hint2.SetActive(false);
                on = false;
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
        on = false;
        Hint.SetActive(false);
        text.SetActive(false);
    }
}
