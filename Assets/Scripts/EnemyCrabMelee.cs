using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrabMelee : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] public float speed = 2.0f;
    [SerializeField] public float stoppingDistance = 1.4f;

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
