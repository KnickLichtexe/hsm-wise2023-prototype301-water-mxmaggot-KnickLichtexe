using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float fishSpeed;
    public Rigidbody rb;
    public GameObject Fish;
    void Start()
    {
        
    }
    void Update()
    {
        rb.AddForce(0, 0, fishSpeed, ForceMode.Force);

        if (transform.position.x <= -30)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy (gameObject);
        }

    }
}
