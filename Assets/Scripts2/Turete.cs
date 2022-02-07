using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turete : MonoBehaviour
{
    public GameObject gm;
    bool doar_odata1 = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Viata_Inamici.nrTentacule==1 && doar_odata1==true)
        {
            Invoke("SpawnZ1",1);
            doar_odata1 = false;
        }
    }
    public void SpawnZ1()
    {
        Instantiate(gm, transform.position, transform.rotation);
    }
}
