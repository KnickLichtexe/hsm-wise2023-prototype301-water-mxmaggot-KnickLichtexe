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
        

        if(Score.ded == false && DuckMovement.win == false)
        {
            transform.position += new Vector3(0, 0, -0.08f);
        }

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
