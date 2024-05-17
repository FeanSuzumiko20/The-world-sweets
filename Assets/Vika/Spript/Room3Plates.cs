using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Plates : MonoBehaviour
{
    public List<Plate> plates;
    public List<GameObject> plates_pos;
    public GameObject door;
    private int currentstage = 0;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(plates[0].activate == true && plates[1].activate == false && plates[2].activate == false && plates[3].activate == false && currentstage == 0)
        {
            currentstage = 1;
        }
        if (plates[0].activate == true && plates[1].activate == true && plates[2].activate == false && plates[3].activate == false && currentstage == 1)
        {
            currentstage = 2;
        }
        if (plates[0].activate == true && plates[1].activate == true && plates[2].activate == true && plates[3].activate == false && currentstage == 2)
        {
            currentstage = 3;
        }
        if (plates[0].activate == true && plates[1].activate == true && plates[2].activate == true && plates[3].activate == true && currentstage == 3)
        {
            door.transform.Rotate(0, 90, 0);
            currentstage++;
        }
        if(plates[1].activate == true && currentstage < 1)
        {
            i = 1;
            StartCoroutine(SomeCoroutine1());
            plates[1].activate = false;
        }
        if (plates[2].activate == true && currentstage < 2)
        {
            i = 2;
            StartCoroutine(SomeCoroutine2());
            plates[2].activate = false;
            
        }
        if (plates[3].activate == true && currentstage < 3)
        {
            i = 3;
            StartCoroutine(SomeCoroutine3());
            plates[3].activate = false;
        }
    }
    private IEnumerator SomeCoroutine1()
    {
        yield return new WaitForSeconds(3);
        plates[1].GoUp();
    }
    private IEnumerator SomeCoroutine2()
    {
        yield return new WaitForSeconds(3);
        plates[2].GoUp();
    }
    private IEnumerator SomeCoroutine3()
    {
        yield return new WaitForSeconds(3);
        plates[3].GoUp();
    }
}
