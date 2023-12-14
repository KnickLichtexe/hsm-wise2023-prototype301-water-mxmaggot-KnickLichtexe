using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour
{
    public Rigidbody Fish;
    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FishSpawner", 1.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    void FishSpawner()
    {
        Rigidbody clone;
        clone = Instantiate(Fish, transform.position, transform.rotation);
        clone.velocity = transform.forward * 3;
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject, 0);
        Score++;
    }
}
