using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody rb;
    public float sideSpeed = -1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, sideSpeed, 0, ForceMode.Force);
            //this.transform.Translate((sideSpeed * (-1)) * Time.deltaTime, 0, 0, Space.World);
        }
        else
        {
            this.transform.Translate(sideSpeed * Time.deltaTime, 0, 0, Space.World);
        }
    }

    
}
