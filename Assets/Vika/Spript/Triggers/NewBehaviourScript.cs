using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject dialogues;
    private void OnTriggerEnter(Collider other)
    {
        dialogues.SetActive(true);
    }
}
