﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public List<Plate> Plates;
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
        if(Plates[0].activate == true & Plates[1].activate == true & Plates[2].activate == true)
        {
            Open();
        }
    }
}
