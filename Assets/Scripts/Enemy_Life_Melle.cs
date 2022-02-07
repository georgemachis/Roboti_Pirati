using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Life_Melle : MonoBehaviour
{
    private Transform target1;
    private Transform target2;
    [SerializeField] public float speed = 2.0f;
    [SerializeField] public float stoppingDistance = 1f;
    public Transform attackPosition;
    public float attackRange;
    public LayerMask TargetToPlayer;
    public int damage;
    private float timeBetweenAttacks;
    public float startTimeBetweenAttacks;

    public static int player1Thread = 10;
    public static int player2Thread = 0;
    private void Start()
    {
        target1 = GameObject.FindGameObjectWithTag("Player1").transform;
        target2 = GameObject.FindGameObjectWithTag("Player2").transform;
    }
    void Update()
    {
        if (player1Thread > player2Thread)
        {
            if (Vector2.Distance(transform.position, target1.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target1.position, speed * Time.deltaTime);
            }

            if (timeBetweenAttacks <= 0)
            {
                Collider2D[] damageToPlayer = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, TargetToPlayer);
                for (int i = 0; i < damageToPlayer.Length; i++)
                {
                    if (damageToPlayer[i].tag == "Player1") 
                    {
                        damageToPlayer[i].GetComponent<Viata_Jucator_1>().DamagePlayer(damage);
                    }
                    if (damageToPlayer[i].tag == "Player2")
                    {
                        damageToPlayer[i].GetComponent<Viata_Jucator_2>().DamagePlayer(damage);
                    }
                }
                timeBetweenAttacks = startTimeBetweenAttacks;
            }
            else
            {
                timeBetweenAttacks -= Time.deltaTime;
            }
        }
        else
        {
            if (Vector2.Distance(transform.position, target2.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target2.position, speed * Time.deltaTime);
            }

            if (timeBetweenAttacks <= 0)
            {
                Collider2D[] damageToPlayer = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, TargetToPlayer);
                for (int i = 0; i < damageToPlayer.Length; i++)
                {
                    if (damageToPlayer[i].CompareTag("Player1"))
                    {
                        damageToPlayer[i].GetComponent<Viata_Jucator_1>().DamagePlayer(damage);
                    }
                    if (damageToPlayer[i].CompareTag("Player2"))
                    {
                        damageToPlayer[i].GetComponent<Viata_Jucator_2>().DamagePlayer(damage);
                    }
                }
                timeBetweenAttacks = startTimeBetweenAttacks;
                
            }
            else
                {
                    timeBetweenAttacks -= Time.deltaTime;
                }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(attackPosition.position, attackRange);
    }
}
