using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public List<EnemyHealth> Enemy;
    public List<GameObject> Enemy2;
    public bool opened = false;
    private void Open()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        if (opened == false)
        {
            transform.Rotate(0, 90, 0);
            opened = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy[0].activate == true)
        {
            Enemy2[0].SetActive(false);
        }
        if (Enemy[1].activate == true)
        {
            Enemy2[1].SetActive(false);
        }
        if (Enemy[0].activate == true & Enemy[1].activate == true)
        {

            Open();
        }
    }
}
