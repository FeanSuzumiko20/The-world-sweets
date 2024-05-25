using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hall : MonoBehaviour
{
    public List<GameObject> Mc;
    public CharacterController player;
    public GameObject GameplayUI;
    public PlayerController playerMove;
    public int current = 0;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        var player2 = other.gameObject.GetComponent<CharacterController>();
        if (player2 != null)
        {
            player.enabled = false;
            playerMove.enabled = false;
            animator.SetBool("run", false);
            GameplayUI.SetActive(false);
            Mc[current].SetActive(true);
            
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0) && current < 3)
        {
            Mc[current].SetActive(false);
            current++;
            Mc[current].SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && current == 2)
        {
            Mc[2].SetActive(true);
            current++;
        }
        if (Input.GetMouseButtonDown(0) && current == 3)
        {
            Mc[current].SetActive(false);
            player.enabled = true;
            playerMove.enabled = true;
            GameplayUI.SetActive(true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }

    }
}