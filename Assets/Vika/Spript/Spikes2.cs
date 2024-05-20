using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes2 : MonoBehaviour
{
    public int secondsoff = 100;
    public int secondson = 200;
    public int seconds = 100;
    public int damage =10;
    PlayerHealth playerHealth;
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (seconds == secondsoff)
        {
            transform.position = transform.position + new Vector3(0, -2f, 0);

        }
        if (seconds == secondson)
        {
            transform.position = transform.position + new Vector3(0, 2f, 0);
            seconds = 0;
        }
        seconds++;



    }
    private void OnTriggerEnter(Collider other)
    {
        if (playerHealth != null)
        {
            playerHealth.DealDamage(damage);
        }
    }
}
