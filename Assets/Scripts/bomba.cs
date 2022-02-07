using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    // Start is called before the first frame update
    public int damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Player1"))
            {
            Viata_Jucator_1.viataActuala -= damage;
            Debug.Log(Viata_Jucator_1.viataActuala);
            Destroy(gameObject);
        }
        if (collision.gameObject.name.Equals("Player2"))
        {
            Viata_Jucator_2.viataActuala -= damage;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Zid"))
        {
            Destroy(gameObject, 1f);

        }
    }
}
