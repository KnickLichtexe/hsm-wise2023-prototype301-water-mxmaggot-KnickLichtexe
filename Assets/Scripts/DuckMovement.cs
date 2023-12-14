using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    public GameObject Player;
    public float sideSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            this.transform.Translate((sideSpeed * (-1)) * Time.deltaTime, 0, 0, Space.World);
        }
        else
        {
            this.transform.Translate(sideSpeed * Time.deltaTime, 0, 0, Space.World);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " just hit " + other.name);

        if (other.gameObject.CompareTag("Shore"))
        {
            sideSpeed = sideSpeed * -1;
        }
    }
}
