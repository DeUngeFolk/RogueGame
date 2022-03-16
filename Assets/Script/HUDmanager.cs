using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDmanager : MonoBehaviour
{

    public Text health_Text;


    public Player player;


    // Start is called before the first frame update
    void Start()
    {


        health_Text.text = player.getCurrentHealth().ToString() + "/" + player.getMaxHealth().ToString();


    }

    // Update is called once per frame
    void Update()
    {
        health_Text.text = player.getCurrentHealth().ToString() + "/" + player.getMaxHealth().ToString();
    }
}
