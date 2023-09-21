using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyreRotation : MonoBehaviour
{
    public float speed = 20.0f;
    public float verticalinput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Taking tyres in control

        verticalinput = Input.GetAxis("Vertical");

        // Rotating tyres forward/backward

        transform.Rotate(Vector3.right * Time.deltaTime * verticalinput * speed);

    }
}
