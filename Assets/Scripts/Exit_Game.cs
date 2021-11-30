using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Exit_Game : MonoBehaviour
{
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        Button exit = exitButton.GetComponent<Button>();
        exit.onClick.AddListener(exitGame);
    }

    private void exitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
