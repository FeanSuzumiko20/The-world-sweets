using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arc1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Hint;
    public GameObject text;
    private void OnTriggerStay(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Hint.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                text.SetActive(true);
                if (Input.GetKey(KeyCode.Escape))
                {
                    text.SetActive(false);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Hint.SetActive(false);
        text.SetActive(false);
    }
}
