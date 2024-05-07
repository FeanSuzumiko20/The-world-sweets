using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPotion : MonoBehaviour
{
    public int healthAmount = 30;

    void OnTriggerEnter(Collider other)
    {
        PlayerHealth player = other.GetComponent <PlayerHealth> ();
        if (player != null)
        {
            player.AddHealth(1);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
