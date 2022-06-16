using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_manager : MonoBehaviour
{

    public Text health_Text;

    public PlayerStats player;


    // Start is called before the first frame update
    void Start()
    {


        health_Text.text = player.currentHealth.ToString() + "/" + player.maxHealth.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        health_Text.text = player.currentHealth.ToString() + "/" + player.maxHealth.ToString();
    }

}
