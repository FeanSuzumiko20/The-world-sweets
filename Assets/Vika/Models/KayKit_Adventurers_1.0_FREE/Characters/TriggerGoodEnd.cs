using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerGoodEnd : MonoBehaviour
{
    public GameObject GoodEnd;
    private void OnTriggerEnter(Collider other)
    {
        var player = other.gameObject.GetComponent<CharacterController>();
        if (player != null)
        {
            GoodEnd.SetActive(true);
        }

    }
    public void Update()
    {
        if (GoodEnd.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(0);
        }
    }
}
