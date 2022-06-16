using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
   
        public Transform pfHealthBar;

    // Start is called before the first frame update
    private void Start()
    {
        

        
        Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0,-0.8f),Quaternion.identity);
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();
     


    }
}
