using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherVehicle : MonoBehaviour
{
    public float speed = 18.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once pe0r frame
    void Update()
    {
        // Moving vechile forward

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
