using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class soundhandler : MonoBehaviour
{

    private AudioSource mysounds;
    private AudioSource mysounds1;

    private AudioSource jump;
    private AudioSource die;

    // Start is called before the first frame update
    void Start()
    {
        mysounds = GetComponent<AudioSource>();
        mysounds1 = GetComponent<AudioSource>();

        die = mysounds1;
        jump = mysounds;
       
    }


    public void PlayDie()
    {
        die.Play();
    }


    // Update is called once per frame
    public void PlayJump()
    {
        jump.Play();
    }

}
