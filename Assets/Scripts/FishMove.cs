using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float fishSpeed;
    private int Score;
    public Rigidbody rb;
    public GameObject Fish;
    void Start()
    {
        
    }
    void Update()
    {
        rb.AddForce(0, 0, fishSpeed, ForceMode.Force);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject, 0);
            Score++;
            Debug.Log(Score);
        }

    }
}
