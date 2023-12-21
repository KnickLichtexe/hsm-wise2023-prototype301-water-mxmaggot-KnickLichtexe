using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckageSpawner : MonoBehaviour
{
    public GameObject Wreckage;
    private float currentX; //current x coordinate of the spawner
    private bool rechts; //flags wether the spawner has reached the far right of its allowed space in this cycle already
    private int chanceToSpawn;
    void Start()
    {
        InvokeRepeating("WreckageSpawn", 1.0f, 1.5f);
        float currentX = this.transform.position.x;
    }

    void Update()
    {    
        
    }

    void WreckageSpawn()
    {
        chanceToSpawn = Random.Range(1, 15);

        if (chanceToSpawn == 4) //assigns random value to int and uses that to randomize spawn
        {
            transform.position = new Vector3(-2, 0, 130);
            GameObject cloneWreckage;
            cloneWreckage = Instantiate(Wreckage, transform.position, transform.rotation * Quaternion.Euler(0f, 90, 0f));
            cloneWreckage.tag = "delete_later";
            //spawns clone of the original and automatically tags it for cleanup (nonfunctional)
        }
        if (chanceToSpawn == 3) //assigns random value to int and uses that to randomize spawn
        {
            transform.position = new Vector3(2, 0, 130);
            GameObject cloneWreckage;
            cloneWreckage = Instantiate(Wreckage, transform.position, transform.rotation * Quaternion.Euler(0f, 90, 0f));
            cloneWreckage.tag = "delete_later";
            //spawns clone of the original and automatically tags it for cleanup (nonfunctional)
        }
        if (chanceToSpawn == 2) //assigns random value to int and uses that to randomize spawn
        {

            transform.position = new Vector3(-5.5f, 0, 130);
            GameObject cloneWreckage;
            cloneWreckage = Instantiate(Wreckage, transform.position, transform.rotation * Quaternion.Euler(0f, 0, -30f));
            cloneWreckage.tag = "delete_later";
            //spawns clone of the original and automatically tags it for cleanup (nonfunctional)
        }
        if (chanceToSpawn == 1) //assigns random value to int and uses that to randomize spawn
        {
            transform.position = new Vector3(5.5f, 0, 130);
            GameObject cloneWreckage;
            cloneWreckage = Instantiate(Wreckage, transform.position, transform.rotation * Quaternion.Euler(0f, 0, 30f));
            cloneWreckage.tag = "delete_later";
            //spawns clone of the original and automatically tags it for cleanup (nonfunctional)
        }
    }
}
