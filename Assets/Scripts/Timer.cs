using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeStart = 0;
    public GameObject gameManager;
    public Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        //timeStart = 0;
        textBox.text = timeStart.ToString("F2");
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

        timeStart += Time.deltaTime;
        textBox.text = timeStart.ToString("F2");

    }
}
