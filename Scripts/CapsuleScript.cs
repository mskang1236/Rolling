using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{

    public bool CapsuleFall = false;
    private GameObject capsule;
    public float CapsuleFallTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        capsule = GameObject.Find("Capsule");
    }

    // Update is called once per frame
    void Update()
    {
        if (capsule.transform.position.y < -20)
        {
            CapsuleFall = true;
            //Destroy(capsule);
            CapsuleFallTime = Time.time;
        }
    }
}
