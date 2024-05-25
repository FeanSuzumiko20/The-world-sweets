using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsSound : MonoBehaviour
{
    public AudioSource playerFootsteps;
    public AudioClip[] footstepsClips;
    void Start()
    {
        
    }

    public void FootstepSound()
    {
        playerFootsteps.PlayOneShot(footstepsClips[Random.Range(0,footstepsClips.Length)]);
    }
}
