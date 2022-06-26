using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public float time = 0.0f;
    public float endTime = 0.0f;
    public GameObject textObj;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (SceneManager.GetActiveScene().name == "Gameplay")
        {
            textObj = GameObject.Find("Time");
            timeText = textObj.GetComponent<Text>();
            time += Time.deltaTime;
            timeText.text = time.ToString("F2");
        }

        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            if (time != 0)
            {
                textObj = GameObject.Find("Time");
                timeText = textObj.GetComponent<Text>();
                endTime = time;
                time = 0;
                timeText.text = endTime.ToString("F2");
            }
        }


    }
}