using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{

    public bool CylinderFall = false;
    private GameObject cylinder;
    public float CylinderFallTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        cylinder = GameObject.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        if (cylinder.transform.position.y < -20) {
            //Destroy(cylinder);
            CylinderFall = true;
            CylinderFallTime = Time.time;
        }
    }
}
