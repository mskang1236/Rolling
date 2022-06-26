using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{

    // Private Variables
    private float horizontalInput;
    private float verticalInput;
    public float turnSpeed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Rotate Ground
        transform.Rotate(Vector3.right, Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.forward, Time.deltaTime * turnSpeed * verticalInput);

    }
}
