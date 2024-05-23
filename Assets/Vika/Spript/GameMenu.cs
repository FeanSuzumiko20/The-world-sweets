using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
    
{public GameObject Menu;
    public CharacterController player;
    public CameraRotation camera;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Menu.SetActive(true);
            camera.enabled = false;
           player.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void Return()
    {
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
