using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float Xleft = -72.0f;
    public float Xright = 72.0f;
    public float Zleft = -15.0f;
    public float Zright = 65.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Xleft)
        {
            Destroy(gameObject);
        }

       /* else if (transform.position.x > Xright)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z > Zleft)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z > Zright)
        {
            Destroy(gameObject);
        }*/
    }
}
