using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOldTime : MonoBehaviour
{

    public GameObject checkTime;
    public GameObject destroy;
    public float timeStart;

    // Start is called before the first frame update
    void Start()
    {
        checkTime = GameObject.Find("GameManager");
        destroy = GameObject.Find("Canvas");
        timeStart = checkTime.GetComponent<Timer>().timeStart;

        if (timeStart == 0)
        {

        }
        else
        {
            Destroy(destroy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
