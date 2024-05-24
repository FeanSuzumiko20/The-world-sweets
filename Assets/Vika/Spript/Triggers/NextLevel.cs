﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        SceneManager.LoadScene(3);
    }
}
