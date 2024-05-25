using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnderDialogue : MonoBehaviour
{
    public List<GameObject> Mc;
    public int current = 0;
    public CharacterController player;
    public GameObject GameplayUI;
    public List<GameObject> Buttons;
    public PlayerController playerMove;
    // Start is called before the first frame update
    void Start()
    {
        player.enabled = false;
        playerMove.enabled = false;
        GameplayUI.SetActive(false);
        Mc[current].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && current < 9)
        {
            Mc[current].SetActive(false);
            current++;
            Mc[current].SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && current == 9)
        {
            Mc[current].SetActive(false);
            Buttons[0].SetActive(true);
            Buttons[1].SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }
    public void BadEnd()
    {
        SceneManager.LoadScene(5);
    }
    public void GoodEnd()
    {
        SceneManager.LoadScene(4);
    }
}


