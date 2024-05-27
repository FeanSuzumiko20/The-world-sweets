using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
    
{public GameObject Menu;
    public CharacterController player;
    public CameraRotation camera;
    public GameObject UI;
    public GameObject UI2;
    public GameObject UI3;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Menu.SetActive(true);
           UI.SetActive(false);
            UI2.SetActive(false);
            UI3.SetActive(false);
            camera.enabled = false;
           player.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void Return()
    {
        UI.SetActive(true);
        UI2.SetActive(true);
        UI3.SetActive(true);
        Time.timeScale = 1;
        camera.enabled = true;
        player.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
public void Quit()
    {
        Application.Quit();
    }
}
