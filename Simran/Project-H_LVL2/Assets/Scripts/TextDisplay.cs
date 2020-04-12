using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    Text txtDisplay;
    PlayerAttack player;

    void Start()
    {
        txtDisplay = GetComponent<Text>();
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<PlayerAttack>();
    }


    void Update()
    {       
            txtDisplay.text = "Ammo: " + player.bulletCount + "/250";
    }
}
