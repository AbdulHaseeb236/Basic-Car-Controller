using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 25.0f;
    public float turnSpeed = 50.0f;
    public float verticalinput;
    public float horizontalinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Taking vehicle in control

        verticalinput = Input.GetAxis("Vertical");
        horizontalinput = Input.GetAxis("Horizontal");

        // Moving vehicle forward/backward

        transform.Translate(Vector3.forward * Time.deltaTime * verticalinput * speed);

        // Rotating vehicle right/left

        transform.Rotate(Vector3.up * Time.deltaTime * horizontalinput * turnSpeed);
        
    }
}
