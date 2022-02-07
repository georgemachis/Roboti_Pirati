using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2_Gloante : MonoBehaviour
{
    public int damage;
    public GameObject gm;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(7, 8);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Viata_Inamici>().DamagePlayer(damage);
            Enemy_Life.player2Thread=Enemy_Life.player2Thread+1;
            Enemy_Life_Melle.player2Thread = Enemy_Life_Melle.player2Thread + 1;
        }
        if (collision.gameObject.CompareTag("Tentacula"))
        {
            collision.gameObject.GetComponent<Viata_Inamici>().DamagePlayer(damage);
            
        }

        GameObject ceva = Instantiate(gm, transform.position, Quaternion.identity);
        Destroy(ceva, 0.2f);
        Destroy(gameObject);
    }

}
