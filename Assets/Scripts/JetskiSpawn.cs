using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetskiSpawn : MonoBehaviour
{
    public GameObject JetSki;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("JetSkiSpawner", 1.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void JetSkiSpawner()
    {
        Instantiate(JetSki, transform.position, transform.rotation);
    }
}
