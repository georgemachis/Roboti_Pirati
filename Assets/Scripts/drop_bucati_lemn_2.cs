using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class drop_bucati_lemn_2 : MonoBehaviour
{
    public static int scorevalue1 = 0;
    public GameObject bucata_lemn;
    public static int bucati_lemn1 = 0;
    bool doar_odata4 = false;
    bool doar_odata5 = false;
    bool doar_odata6 = false;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scorevalue1 > 150 && doar_odata4 == false)
        {
            SpawnLemn();
            doar_odata4 = true;
        }
        if (scorevalue1 > 100 && doar_odata5 == false)
        {
            SpawnLemn();
            doar_odata5 = true;
        }
        if (scorevalue1 > 10 && doar_odata6 == false)
        {
            SpawnLemn();
            doar_odata6 = true;
        }
        if (bucati_lemn1 == 3)
        {
            SceneManager.LoadScene(4);
        }

        score.text = "Bucati lemn " + bucati_lemn1;

    }
    void SpawnLemn()
    {

        float x = Random.Range(-6.0f, 6.0f);
        float y = Random.Range(-6.0f, 6.0f);
        Instantiate(bucata_lemn, new Vector2(x, y), Quaternion.identity);
    }

}
