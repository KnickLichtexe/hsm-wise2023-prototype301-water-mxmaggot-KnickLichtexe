using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class Score : MonoBehaviour
{
    private Animator a_Animator;

    public Text textScore;
    public Text GameOver;
    public Text Restart;
    public static int scorenumber;
    public static bool ded = false;

    public AudioSource Beating;
    // Start is called before the first frame update
    void Start()
    {
        ded = false;
        scorenumber = 0;
        a_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {
        textScore.text = scorenumber.ToString() + "/5" + " Golden-Fish eaten";

        if(ded == true && DuckMovement.win == false)
        {
            Beating.Play();
            a_Animator.SetBool("Death", true);
            GameOver.text = "Game Over";
            Restart.text = "Press R to Play Again";
        }
    }

}
