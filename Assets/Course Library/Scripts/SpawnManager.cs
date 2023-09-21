using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Carprefab;
    public float Xleft = -72.0f;
    public float Xright = 72.0f;
    public float Zleft = -15.0f;
    public float Zright = -65.0f;
    private float startdelay = 1.0f;
    private float Interval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        // To spawn gameobjects automatically
         InvokeRepeating("Spawner", startdelay, Interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawner ()
    {
        int carindex = Random.Range(0, Carprefab.Length);
        Vector3 spawnposition = new Vector3(Random.Range(Xleft, Xright), 0, Random.Range(Zleft, Zright));

        Instantiate(Carprefab[carindex], spawnposition, Carprefab[carindex].transform.rotation);
    }
}
