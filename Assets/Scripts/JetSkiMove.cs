using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetSkiMove : MonoBehaviour
{
    public GameObject JetSki;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Score.ded == false)
        { 
        transform.position += new Vector3(0, 0, -0.08f);
        }

        if(transform.position.x <= -30)
        {  
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.ded = true;
        }

    }
}
