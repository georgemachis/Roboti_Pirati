using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2_Gloante : MonoBehaviour
{
    public int damage;
    public GameObject gm;

    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Viata_Inamici>().DamagePlayer(damage);
            Enemy_Life.player2Thread=Enemy_Life.player2Thread+1;
            Debug.Log("P2 "+Enemy_Life.player1Thread);
        }
        GameObject ceva = Instantiate(gm, transform.position, Quaternion.identity);
        Destroy(ceva,0.2f);
        Destroy(gameObject);
    }
}
