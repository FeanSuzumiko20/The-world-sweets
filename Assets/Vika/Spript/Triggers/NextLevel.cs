using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    public AudioSource audio;
    public int i;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        SceneManager.LoadScene(i);
    }
}
