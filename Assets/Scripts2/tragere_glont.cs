using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tragere_glont : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    
    public int timp_intre_gloante;
    float timp_intre;
    public float bulletForce = 2f;
    // Start is called before the first frame update
    void Start()
    {
        timp_intre = timp_intre_gloante;
       
    }

    // Update is called once per frame
    void Update()
    {
         if (timp_intre <= 0)
        {
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            timp_intre = timp_intre_gloante;
        }
        else
        {
            timp_intre -= Time.deltaTime;
        }
    }
}
