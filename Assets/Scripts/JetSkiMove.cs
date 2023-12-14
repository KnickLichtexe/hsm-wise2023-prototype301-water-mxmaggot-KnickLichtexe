using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetSkiMove : MonoBehaviour
{
    public float skiSpeed;
    public Rigidbody rb;
    public GameObject JetSki;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, skiSpeed, ForceMode.Force);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject, 0);
        }

    }
}
