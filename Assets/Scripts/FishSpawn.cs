using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour
{
    public GameObject Fish;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FishSpawner", 1.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FishSpawner()
    {
        Instantiate(Fish, transform.position, transform.rotation);
    }
    
}
