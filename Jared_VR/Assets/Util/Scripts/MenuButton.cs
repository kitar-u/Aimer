using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{

    [SerializeField] private GameObject targets, barriers, gun, UI;

    public void buttonPlay()
    {
        targets.SetActive(true);
        barriers.SetActive(true);
        gun.SetActive(true);
        UI.SetActive(false);
    }

    public void quitGame() 
    {
        Application.Quit();
    }
}
