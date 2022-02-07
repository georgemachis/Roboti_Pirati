using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turete_sus1 : MonoBehaviour
{
    bool doar_odata1 = true;
    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Viata_Inamici.nrTentacule == 4 && doar_odata1 == true)
        {
            Invoke("SpawnZ2", 1);
            doar_odata1 = false;
        }
    }
    public void SpawnZ2()
    {
        Instantiate(gm, transform.position, transform.rotation);
    }
}
