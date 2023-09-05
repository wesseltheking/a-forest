using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep : MonoBehaviour
{
    public AudioSource footstepsSound, sprintSound, jump;
    public CharacterController player;

    AudioSource audioSource;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            jump.Play();
        }
        if (player.isGrounded == false)
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (useDrugs.high == true)
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
    }
}