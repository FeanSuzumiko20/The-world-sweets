using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject Dia;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    IEnumerator waiter()
    {
        Dia.SetActive(true);
        yield return new WaitForSeconds(3);
        Dia.SetActive(false);
    }
}
