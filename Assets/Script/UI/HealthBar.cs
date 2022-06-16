using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    private Transform bar;
    private HealthSystem healthSystem;

    public void Setup(HealthSystem healthSystem) {
      this.healthSystem = healthSystem;  
      bar = transform.Find("Bar");

      healthSystem.onHealthChanged += healthSystem_OnHealthChanged;
    }

    private void healthSystem_OnHealthChanged(object sender, System.EventArgs e){
        bar.localScale = new Vector3(healthSystem.GetHealthPercent(),1);
    }

    public void SetSize(float sizeNormalized) {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    public void SetColor(Color color){

        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;

    }

}
