using Main.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Init : MonoBehaviour
{
    public Player_Main playerMain;
    public GameObject man;
    public GameObject woman;
    private void Awake()
    {
        if (playerMain.settings.isMan)
            man.SetActive(true);
        else
            woman.SetActive(true);

    }
}
