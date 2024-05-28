using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterDialogue : MonoBehaviour
{
    public List<GameObject> Mc;
    public int current = 0;
    public CharacterController player;
    public PlayerController playerMove;
    public GameObject GameplayUI;
    public GameObject GameplayUI3;
    public GameObject GameplayUI2;
    // Start is called before the first frame update
    void Start()
    {
        player.enabled = false;
        playerMove.enabled = false;
        GameplayUI.SetActive(false);
        GameplayUI2.SetActive(false);
        GameplayUI3.SetActive(false);
        Mc[current].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && current < 23)
        {
            Mc[current].SetActive(false);
            current++;
            Mc[current].SetActive(true);
            GameplayUI3.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0) && current == 23)
        {
            Mc[current].SetActive(false);
            current++;
            GameplayUI3.SetActive(false);
        }

            if (Input.GetMouseButtonDown(0) && current == 24)
        {
            player.enabled = true;
            playerMove.enabled = true;
            GameplayUI.SetActive(true);
            GameplayUI2.SetActive(true);
            GameplayUI3.SetActive(false);
        }
    }

}
