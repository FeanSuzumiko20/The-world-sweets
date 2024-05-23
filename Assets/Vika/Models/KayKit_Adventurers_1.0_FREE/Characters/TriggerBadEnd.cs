using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerBadEnd : MonoBehaviour
{
    public GameObject BadEnd;
    Vector3 pos;
   
    float timer = 0;
     public bool move = false;
    private void OnTriggerEnter(Collider other)
    {
        var player = other.gameObject.GetComponent<CharacterController>();
        if (player != null)
        {
           
        }

    }
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
        if (move== true)
        {
            transform.position = Vector3.Lerp(pos, pos + new Vector3(-10, 0, -10), timer / 3);
            timer += Time.deltaTime;
        }
        if (BadEnd.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(0);
        }
    }
   
}
