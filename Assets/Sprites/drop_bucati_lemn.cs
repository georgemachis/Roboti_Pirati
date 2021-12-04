using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class drop_bucati_lemn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Drop_Bucati_Lemn.bucati_lemn++;
    }
}
