using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveMessages : MonoBehaviour
{

    public OSC osc;
    public float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler("/PhoneXYZ", OnReceiveXYZ);
        osc.SetAddressHandler("/PhoneX", OnReceiveX);
        osc.SetAddressHandler("/PhoneY", OnReceiveY);
        osc.SetAddressHandler("/PhoneZ", OnReceiveZ);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(x);
    }

    void OnReceiveXYZ(OscMessage message)
    {
        x = message.GetFloat(0);
        y = message.GetFloat(1);
        z = message.GetFloat(2);

        transform.position = new Vector3(x, y, z);
    }

    void OnReceiveX(OscMessage message)
    {
        x = message.GetFloat(0);
        Vector3 position = transform.position;
        position.x = x;
        transform.position = position;
    }

    void OnReceiveY(OscMessage message)
    {
        y = message.GetFloat(1);
        Vector3 position = transform.position;
        position.y = y;
        transform.position = position;
    }

    void OnReceiveZ(OscMessage message)
    {
        z = message.GetFloat(2);
        Vector3 position = transform.position;
        position.z = z;
        transform.position = position;
    }
}
