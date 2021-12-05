using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrabMelee : MonoBehaviour
{

    [SerializeField] public Transform target;
    [SerializeField] public float speed = 2.0f;
    [SerializeField] public float stoppingDistance = 1.4f;
    public Transform attackPosition;
    public float attackRange;
    public LayerMask TargetToPlayer;
    public int damage;
    private float timeBetweenAttacks;
    public float startTimeBetweenAttacks;

    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if (timeBetweenAttacks <= 0)
        {
            Collider2D[] damageToPlayer = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, TargetToPlayer);
            for (int i = 0; i < damageToPlayer.Length; i++)
            {
                damageToPlayer[i].GetComponent<Viata_Jucator_1>().DamagePlayer(damage);
            }
            timeBetweenAttacks = startTimeBetweenAttacks;
        }
        else
        {
            timeBetweenAttacks -= Time.deltaTime;
        }
    }
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(attackPosition.position, attackRange);
    }
}
