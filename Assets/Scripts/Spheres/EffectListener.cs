using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectListener : MonoBehaviour
{

    Rigidbody rb;
    Animator animator;
    PlayerMovement playerMovement;
    AudioSource ac;

    
    public AudioClip fastForward;
    public AudioClip pause;
    public AudioClip rewind;

    public PhysicMaterial ballPhysicsMaterial;

    public bool isEffectedbyRewind;
    public bool isEffectedbyPause;
    public bool isEffectedbyForward;

    public float startingDrag;
    public float startingMass;
    public float animatorSpeed;
    public float movementSpeed;

    public float gravityMultiplier;

    private bool hasPlayedFastForwardOnce = false;
    public bool hasPlayedPauseOnce = false;
    private bool hasPlayedRewindOnce = false;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        ballPhysicsMaterial = GetComponent<PhysicMaterial>();
        ac = GetComponent<AudioSource>();
        startingDrag = rb.drag;
        startingMass = rb.mass;
        if (animator != null && playerMovement != null)
        {
            animatorSpeed = animator.speed;
            movementSpeed = playerMovement.movementSpeed;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        //PAUSE
        if (isEffectedbyPause)
        {
            if (animator)
            {
                if (!hasPlayedPauseOnce)
                {
                    if (!ac.isPlaying)
                    {
                        ac.PlayOneShot(pause);
                        hasPlayedPauseOnce = true;
                    }
                }
                animator.speed -= 0.3f * Time.deltaTime;
                if (animator.speed <= 0.01f)
                {
                    animator.speed = 0.01f;
                }
                playerMovement.movementSpeed -= 8 * Time.deltaTime;
                if (playerMovement.movementSpeed <= 0)
                {
                    playerMovement.movementSpeed = 0;
                }
                
            }
        }
        else
        {
            if (animator)
            {
                animator.speed = animatorSpeed;
                playerMovement.movementSpeed = movementSpeed;
                hasPlayedPauseOnce = false;

            }
        }

        //REWIND
        if (isEffectedbyRewind)
        {
            if (!hasPlayedRewindOnce)
            {
                if (animator)
                {
                    ac.PlayOneShot(rewind);
                    transform.Find("PsHolderFront" + this.transform.tag).GetComponentInChildren<ParticleSystem>().Play();
                    hasPlayedRewindOnce = true;
                }
                

                
            }
            if (animator)
            {
                //GetComponentInChildren<ParticleSystem>().Play();
                
            }
        }
        else
        {
            if (animator)
            {
                hasPlayedRewindOnce = false;
                transform.Find("PsHolderFront" + this.transform.tag).GetComponentInChildren<ParticleSystem>().Stop();
            }
        }

        //FAST FORWARD
        if (isEffectedbyForward)
        {
            if (!hasPlayedFastForwardOnce)
            {
                
                
                if (animator)
                {
                    ac.PlayOneShot(fastForward);
                    transform.Find("PsHolder" + this.transform.tag).GetComponentInChildren<ParticleSystem>().Play();
                }
                    
                    

                
                hasPlayedFastForwardOnce = true;
            }
            
            
            if (animator)
            {
                animator.speed += 0.3f * Time.deltaTime;

                if (animator.speed >= 3.0f)
                {
                    animator.speed = 3.0f;
                }
                playerMovement.movementSpeed = 30f;


                



            }
            else
            {
                if (animator)
                {
                    animator.speed = animatorSpeed;
                    playerMovement.movementSpeed = movementSpeed;
                    hasPlayedFastForwardOnce = false;
                    
                }

                // if its a ball

            }

        }
        else
        {
            if (animator)
            {
                transform.Find("PsHolder" + this.transform.tag).GetComponentInChildren<ParticleSystem>().Stop();
                hasPlayedFastForwardOnce = false;
            }
            
        }
    }
                

            

           

    

    private void FixedUpdate()
    {
        if (isEffectedbyPause)
        {
            rb.drag += 10 * Time.deltaTime;
            rb.mass -= 1 * Time.deltaTime;
            rb.useGravity = false;
            
            
        }
        else
        {
            rb.drag = startingDrag;
            rb.mass = startingMass;
            rb.useGravity = true;
            
            
        }

        if (isEffectedbyRewind)
        {
            

        }
    }

    
}
