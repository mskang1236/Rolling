using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public bool cubeFall = false;
    public float cubeFallTime = 0.0f;
    private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (cube.transform.position.y < -20)
        {
            //Destroy(cube);
            cubeFall = true;
            cubeFallTime = Time.time;
            Debug.Log(cubeFallTime);
        }
    }
}
