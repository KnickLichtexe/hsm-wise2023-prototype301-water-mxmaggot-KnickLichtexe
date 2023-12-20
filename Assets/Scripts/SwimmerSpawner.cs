using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmerSpawner : MonoBehaviour
{
    public GameObject Swimmer;
    private float slide = 0.9f; //movement speed
    private float currentX; //current x coordinate of the spawner
    private bool rechts; //flags wether the spawner has reached the far right of its allowed space in this cycle already
    private int chanceToSpawn;
    void Start()
    {
        InvokeRepeating("SwimmerSpawn", 1.0f, 1.5f);
        float currentX = this.transform.position.x;
    }

    void Update()
    {
       // float currentX = this.transform.position.x; //update x coordinate
       // this.transform.Translate(slide * Time.deltaTime, 0, 0, Space.World); //move the spawner to the right
       // {
       //     slide = slide * (-1); //invert movement speed
       //     rechts = true;
       // }
       // else if (currentX < -3 && rechts == true) //returns true if the spawner is moving beyond the left edge of its cage coming from the right
       // {
       //     slide = slide * (-1);
       //     rechts = false;
       // }
    }

    void SwimmerSpawn()
    {
        chanceToSpawn = Random.Range(1, 7);
        if (chanceToSpawn <= 2) //assigns random value to int and uses that to randomize spawn
        {
            GameObject cloneSwimmer;
            cloneSwimmer = Instantiate(Swimmer, transform.position, transform.rotation * Quaternion.Euler(0f, 0, 90f));
            cloneSwimmer.tag = "delete_later";
            //spawns clone of the original and automatically tags it for cleanup (nonfunctional)
        }
    }
}

