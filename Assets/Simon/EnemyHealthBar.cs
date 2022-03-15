using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
   public float health;
   public float maxhealth;

    public GameObject healthBarUI;
   public Slider slider;

   void start()
   {
       health = maxhealth;
        slider.value = CalculateHealth();
   }
   void update()
   {
       slider.value = CalculateHealth();

       if (health < maxhealth) 
       {
           healthBarUI.SetActive(true);
       }
       if (health <= 0 )
       {
           Destroy(GameObject);
       }
       if (health > maxhealth)
       {
           health = maxhealth;
       }
   }
   float CalculateHealth(){
       return health / maxhealth; 
   }
}
