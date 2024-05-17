using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public PlayerController player;
    public bool activate = false;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            transform.position = transform.position + new Vector3(0, -0.2f,0 );
            gameObject.GetComponent<BoxCollider>().enabled = false;
            activate = true;
        }
       
    }
    public void GoUp() 
    {
        transform.position = transform.position + new Vector3(0, 0.2f, 0);
        gameObject.GetComponent<BoxCollider>().enabled = true;
        activate = false;
    }
}
