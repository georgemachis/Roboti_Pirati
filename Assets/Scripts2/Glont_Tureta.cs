using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glont_Tureta : MonoBehaviour
{
    public Transform pozitieFinala;
    public float speed;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(0, 3);
        Physics2D.IgnoreLayerCollision(0, 1);
        Physics2D.IgnoreLayerCollision(0, 7);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, pozitieFinala.position,speed*Time.deltaTime);
        speed += 0.02f;
        Destroy(gameObject, 2f);
        
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player1"))
        {
            collision.gameObject.GetComponent<Viata_Jucator_1>().DamagePlayer(damage);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            collision.gameObject.GetComponent<Viata_Jucator_2>().DamagePlayer(damage);
            Destroy(gameObject);
        }
    }
}
