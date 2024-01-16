using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Ducky");
        }
        if (Input.GetKeyDown("space") && DuckMovement.win == true)
        {
            SceneManager.LoadScene("Ducky");
        }
        if (Input.GetKeyDown("space") && Score.ded == true)
        {
            SceneManager.LoadScene("Ducky");
        }
    }
}
