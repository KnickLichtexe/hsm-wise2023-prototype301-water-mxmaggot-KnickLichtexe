using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DuckMovement : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody rb;
    private int Score;
    public float sideSpeed = 1f;
    private float currentX;
    private bool rechts;
    void Start()
    {
        float currentX = this.transform.position.x;
    }

    void Update()
    {
        float currentX = this.transform.position.x;
        if (Input.GetKey("space"))
        {
            this.transform.Translate(sideSpeed, 0, 0, Space.World);
            //probably a braindead way of doing this, checks wether the duck is about to collide with the shore by comparing its x coordinate with a preset value (cf spawner)
            //you could probably use a collision system and rb.addforce instead but that made changing directions a nightmare so fuck it
            if (currentX > 4.5 && rechts == false)
            {
                sideSpeed = sideSpeed * (-1);
                rechts = true;
            }
            else if (currentX < -4.5 && rechts == true)
            {
                sideSpeed = sideSpeed * (-1);
                rechts = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("delete_later"))
        {
            Score++;
            Debug.Log(Score);
        }

    }

}
