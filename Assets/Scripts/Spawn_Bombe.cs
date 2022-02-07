using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Bombe : MonoBehaviour
{
    public GameObject bomba;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBombe", 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnBombe()
    {
        float x = Random.Range(-10.0f, 10.0f);
        float y = Random.Range(-5.5f, 5.5f);
        Instantiate(bomba, new Vector2(x, y), Quaternion.identity);
    }
}
