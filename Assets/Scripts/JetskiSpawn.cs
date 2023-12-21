using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetskiSpawn : MonoBehaviour
{
    public GameObject JetSki;
    private float slide = 0.9f; //movement speed
    private float currentX; //current x coordinate of the spawner
    private bool rechts; //flags wether the spawner has reached the far right of its allowed space in this cycle already
    private int chanceToSpawn;
    void Start()
    {
        InvokeRepeating("JetSkiSpawner", 1.0f, 1.5f);
        float currentX = this.transform.position.x;
    }

    void Update()
    {
        float currentX = this.transform.position.x; //update x coordinate
        this.transform.Translate(slide * Time.deltaTime, 0, 0, Space.World); //move the spawner to the right
        if (currentX > 3 && rechts == false) //returns true if the spawner is moving beyond the right edge of its cage coming from the left
        {
            slide = slide * (-1); //invert movement speed
            rechts = true;
        }
        else if (currentX < -3 && rechts == true) //returns true if the spawner is moving beyond the left edge of its cage coming from the right
        {
            slide = slide * (-1);
            rechts = false;
        }
    }

    void JetSkiSpawner()
    {
        chanceToSpawn = Random.Range(1, 7);
        if (chanceToSpawn <= 2) //assigns random value to int and uses that to randomize spawn
        {
            GameObject cloneSki;
            cloneSki = Instantiate(JetSki, transform.position, transform.rotation);
            cloneSki.tag = "delete_later";
            //spawns clone of the original and automatically tags it for cleanup (nonfunctional)
        }
    }
}
