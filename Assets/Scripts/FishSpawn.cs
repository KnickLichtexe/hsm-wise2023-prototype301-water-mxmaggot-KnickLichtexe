using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour
{
    public GameObject Fish;
    private float slide = -0.9f; //movement speed
    private float currentX; //current x coordinate of the spawner
    private bool links; //flags wether the spawner has reached the far left of its allowed space in this cycle already
    private int chanceToSpawn;
    void Start()
    {
        InvokeRepeating("FishSpawner", 1.0f, 3.0f);
        float currentX = this.transform.position.x;
    }

    void Update()
    {
        float currentX = this.transform.position.x; //update x coordinate
        this.transform.Translate(slide * Time.deltaTime, 0, 0, Space.World); //move the spawner to the left
        if (currentX < -3 && links == false) //returns true if the spawner is moving beyond the left edge of its cage coming from the right
        {
            slide = slide * (-1); //invert movement speed
            links = true; //spawner has hit the left edge, do not trigger if loop again before hitting the right edge
        }
        else if (currentX > 3 && links == true) //returns true if the spawner is moving beyond the right edge of its cage coming from the left
        {
            slide = slide * (-1);
            links = false;
        }
    }

    void FishSpawner()
    {
        chanceToSpawn = Random.Range(1, 10);
        if (chanceToSpawn <= 6 && Score.ded == false && DuckMovement.win == false) //assigns random value to int and uses that to randomize spawn
        {
            GameObject cloneFish;
            cloneFish = Instantiate(Fish, transform.position, transform.rotation * Quaternion.Euler(0f, 180f, 0));
            cloneFish.tag = "food";
            //spawns clone of the original and automatically tags it for cleanup (nonfunctional)

        }

    }
}

//TO DO:
//score doesnt tick up
//display score
//cull clones once they are off the screen
