using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerCamera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        Camera camera = player.GetComponent<Camera>();
        gameObject.GetComponent<Canvas>().worldCamera = camera;
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
