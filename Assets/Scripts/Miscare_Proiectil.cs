using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miscare_Proiectil : MonoBehaviour
{
    public int damage;


    public float speed;
    private Transform player1;
    private Transform player2;
    private Vector2 target1;
    private Vector2 target2;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1").transform;
        target1 = new Vector2(player1.position.x, player1.position.y);
        player2 = GameObject.FindGameObjectWithTag("Player2").transform;
        target2 = new Vector2(player2.position.x, player2.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy_Life.player2Thread * 2 < Enemy_Life.player1Thread) { 
        transform.position = Vector2.MoveTowards(transform.position, target1, speed * Time.deltaTime);
        if (transform.position.x == target1.x && transform.position.y == target1.y)
        {
            DestroyProiectil();
        }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target2, speed * Time.deltaTime);
            if (transform.position.x == target2.x && transform.position.y == target2.y)
            {
                DestroyProiectil();
            }
        }
  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            DestroyProiectil();
            collision.GetComponent<Viata_Jucator_1>().DamagePlayer(damage);
        }
        if(collision.CompareTag("Player2"))
        {
            DestroyProiectil();
            collision.GetComponent<Viata_Jucator_2>().DamagePlayer(damage);
        }    
    }
    void DestroyProiectil()
    {
        Destroy(gameObject);
    }
}
