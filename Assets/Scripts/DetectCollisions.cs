using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject starsParticles;
    public AudioClip catchClip;
    
    private int counter;
    private AudioSource playerAudioSource;

    private void Start()
    {
        playerAudioSource = GameObject.Find("Player").GetComponent<AudioSource>();
        counter = 0;
    }

    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("Present"))
        {
            counter -= 2;
            Debug.Log($"Llevas {counter} regalos recogidos");
            
            Destroy(gameObject);
            
            Vector3 particlesPos = new Vector3(otherTrigger.transform.position.x, 1, 0);
            Instantiate(starsParticles, particlesPos,
                starsParticles.transform.rotation);
            playerAudioSource.PlayOneShot(catchClip, 1f);
        }
    }
}
