using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    
    Vector3 pos;
    float timer = 0;
    bool move = false;

    void Start()
    {
        pos = transform.position;
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        move = true;
    }
    void Update()
    {
        if (move)
        {
            transform.position = Vector3.Lerp(pos, pos + new Vector3(-20, 0, 0), timer / 3);
            timer += Time.deltaTime;
        }
    }
}
