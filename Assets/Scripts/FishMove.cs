using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float fishSpeed;
    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, fishSpeed * Time.deltaTime, Space.World);
        OnTriggerEnter();
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject, 0);
        Score++;
        Debug.Log("Score = " + Score);
    }
}
