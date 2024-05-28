using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public List<GameObject> Points;
    public List<ShieldPoint> Points2;
    public AudioSource audio;
    public int Stage = 0;
    public bool opened = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Stage == 5 )
        {
            Open();
        }
    }
    private void Open()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        if (opened == false)
        {
            transform.Rotate(0, 90, 0);
            opened = true;
            audio.Play();
        }
    }

}
