using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckageMovement : MonoBehaviour
{
    public GameObject Wreckage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Score.ded == false && DuckMovement.win == false)
        {
            transform.position += new Vector3(0, 0, -0.017f);
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
            Debug.Log("UR DEAD!");
            Score.ded = true;
        }

    }
}