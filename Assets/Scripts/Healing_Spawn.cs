using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing_Spawn : MonoBehaviour
{
    public GameObject healing_point;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHeal", 1, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnHeal()
    {
        float x = Random.Range(-10.0f,10.0f);
        float y = Random.Range(-5.5f, 5.5f);
        Instantiate(healing_point, new Vector2(x, y), Quaternion.identity);
    }
}
