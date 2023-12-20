using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmerMovement : MonoBehaviour
{
    public float SwimmerSpeed, SwimSpeed;
    public Rigidbody rb;
    public GameObject JetSki;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-SwimSpeed, 0, SwimmerSpeed, ForceMode.Force);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject, 0);
            Debug.Log("UR DEAD!");
        }

    }
}