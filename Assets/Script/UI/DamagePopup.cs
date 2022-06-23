using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePopup : MonoBehaviour
{
    // create damage popup
    public static DamagePopup Create(Vector3 position, int damageAmount)
    {
        Transform damagePopupTransform =
            Instantiate(GameAssets.i.pfDamagePopup,
            position,
            Quaternion.identity);
        DamagePopup damagePopup =
            damagePopupTransform.GetComponent<DamagePopup>();
        damagePopup.Setup (damageAmount);

        return damagePopup;
    }

    private TextMeshPro textMesh;

    private float dissapearTimer;

    private Color textColor;

    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    public void Setup(int damageAmount)
    {
        textMesh.SetText(damageAmount.ToString());
        textColor = textMesh.color;
        dissapearTimer = 1f;
    }

    private void Update()
    {
        float moveYspeed = 4f;
        transform.position += new Vector3(0, moveYspeed) * Time.deltaTime;

        dissapearTimer -= Time.deltaTime;
        if (dissapearTimer < 0)
        {
            textColor.a -= 3f * Time.deltaTime;
            textMesh.color = textColor;
            if (textColor.a < 0)
            {
                Destroy (gameObject);
            }
        }
    }
}
