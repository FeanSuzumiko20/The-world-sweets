using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGold : MonoBehaviour
{
    public Animator animator;
    public TriggerBadEnd BadEndTrigger;
    public GameObject BAdEnd;
    public GameObject Death;
    Vector3 pos;
    float timer = 0;
    public bool dead = false;
    public GameObject DeathScreen;
    public AudioSource audio;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    // Start is called before the first frame update
    void Start()
    {
        pos = Death.transform.position;
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        dead = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (dead== true)
        {
            animator.SetBool("hit",true);
            animator.ResetTrigger("bad");
            Death.transform.position = Vector3.Lerp(pos, pos + new Vector3(0, -3, 0), timer / 1);
            timer += Time.deltaTime;
            StartCoroutine(Deathy());
        }
        if (DeathScreen.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        var player = other.gameObject.GetComponent<CharacterController>();
        if (player != null)
        {
            animator.SetTrigger("bad");
            BadEndTrigger.move = false;
            BAdEnd.SetActive(true);
            audio.Stop();
            audio3.Play();
            audio2.Play();
            audio4.Play();
            StartCoroutine(waiter());
        }
    }
    IEnumerator Deathy()
    {
        
        BAdEnd.SetActive(false);
        yield return new WaitForSeconds(1);
        DeathScreen.SetActive(true); 
    }
}
