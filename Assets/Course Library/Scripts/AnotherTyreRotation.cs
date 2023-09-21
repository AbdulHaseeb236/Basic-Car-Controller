using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherTyreRotation : MonoBehaviour
{
    public float turnSpeed = 40.0f;
    public float horizontalinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Taking tyres in control

        horizontalinput = Input.GetAxis("Horizontal");

        // Rotating tyres right/left

        transform.Rotate(Vector3.up * Time.deltaTime * horizontalinput * turnSpeed);
    }
}
