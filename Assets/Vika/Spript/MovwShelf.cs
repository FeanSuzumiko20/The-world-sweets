using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovwShelf : MonoBehaviour
{
    Vector3 pos;
    float timer = 0;
    bool move = false;
    public int _i;
     public int _b;
    public int i;
    public int b;

    void Start()
    {
        pos = transform.position;
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(b);
        transform.position = pos + new Vector3(_b, 0, 0);
        yield return new WaitForSeconds(1);
        transform.position = pos + new Vector3(_i, 0, 0);
        yield return new WaitForSeconds(1);
        transform.position = pos + new Vector3(_b, 0, 0);
        yield return new WaitForSeconds(1);
        transform.position = pos + new Vector3(b, 0, 0);
        yield return new WaitForSeconds(1);
        transform.position = pos + new Vector3(i, 0, 0);
        yield return new WaitForSeconds(1);
        transform.position = pos + new Vector3(b, 0, 0);
        StartCoroutine(waiter());
    }
    void Update()
    {
    }
}
