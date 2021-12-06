using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Drop_Bucati_Lemn : MonoBehaviour
{
    public static int scorevalue= 0;
    public GameObject bucata_lemn;
    public static int bucati_lemn = 0;
    bool doar_odata1 = false;
    bool doar_odata2 = false;
    bool doar_odata3 = false;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scorevalue>800 && doar_odata3==false)
        {
            SpawnLemn();
            doar_odata3 = true;
        }
        if (scorevalue > 400 && doar_odata2 == false)
        {
            SpawnLemn();
            doar_odata2 = true;
        }
        if (scorevalue > 100  && doar_odata1 == false)
        {
            SpawnLemn();
            doar_odata1 = true;
        }

        score.text = "Bucati lemn " + bucati_lemn;
        if(bucati_lemn==3)
        {
            SceneManager.LoadScene(2);
        }
    }
    void SpawnLemn()
    {
       
        float x = Random.Range(-6.0f, 6.0f);
        float y = Random.Range(-6.0f, 6.0f);
        Instantiate(bucata_lemn, new Vector2(x, y), Quaternion.identity);
    }
}
