using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Viata_Inamici : MonoBehaviour
{
    public int viataActuala = 0;
    public int maxHp = 100;
    public Slider healthBar;
    public static int nrTentacule=0;
    private void Start()
    {
        viataActuala = maxHp;
        healthBar.value = viataActuala;
        healthBar.maxValue = maxHp;

    }
    private void Update()
    {
        if (viataActuala <= 0)
        {
            Drop_Bucati_Lemn.scorevalue += 10;
            
            if(gameObject.CompareTag("Tentacula"))
            {
                nrTentacule++;
                Destroy(gameObject);
            }
            Destroy(gameObject);
            if(viataActuala<=0 && gameObject.name.Equals("Boss"))
            {
                SceneManager.LoadScene(5);
            }

        }
        if (gameObject.name.Equals("Boss") && nrTentacule!=4)
        {
            viataActuala = maxHp;
        }

    }

    public void DamagePlayer(int v)
    {
        viataActuala -= v;
        healthBar.value = viataActuala;
    }
}
