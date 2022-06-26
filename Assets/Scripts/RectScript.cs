using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectScript : MonoBehaviour
{

    public bool RectFall = false;
    private GameObject rect;

    // Start is called before the first frame update
    void Start()
    {
        rect = GameObject.Find("Rect");
    }

    // Update is called once per frame
    void Update()
    {
        if (rect.transform.position.y < -20)
        {
            //Destroy(rect);
            RectFall = true;
        }
    }
}
