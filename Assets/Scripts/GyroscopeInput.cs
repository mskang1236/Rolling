using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroscopeInput : MonoBehaviour
{

    //public Text _gravity, _attitude, _rotationRate, _userAcceleration;
    public Transform cubeTransform;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
        cubeTransform.rotation = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        var gravity = Input.gyro.gravity;
        var attitude = Input.gyro.attitude;
        var rotationRate = Input.gyro.rotationRate;
        var userAcceleration = Input.gyro.userAcceleration;

        /*
        _gravity.text = "gravity : " + gravity.ToString();
        _attitude.text = "attitude : " + attitude.ToString();
        _rotationRate.text = "rotationRate : " + rotationRate.ToString();
        _userAcceleration.text = "userAcceleration : " + userAcceleration.ToString();
        */
        //Debug.Log(attitude.eulerAngles);
        //cubeTransform.rotation = Quaternion.Euler(attitude.eulerAngles);
        cubeTransform.rotation = new Quaternion (attitude.x, 0, attitude.y, -attitude.w);
    }
}
