using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPoint : MonoBehaviour
{
    public Material mainMat;
    public Shield shield;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        DestroyItself(other);



    }
    private void DestroyItself(Collider other)
    {
        var fireball = other.gameObject.GetComponent<Fireball>();
        if (fireball != null)
        {
            gameObject.SetActive(false);
            shield.Stage += 1;
            rend.sharedMaterial = mainMat;
        }
    }
   
}
