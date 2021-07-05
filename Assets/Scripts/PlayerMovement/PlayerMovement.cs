using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    Animator animator;
    Controls controls;
    EffectListener EL;
    PlayerInput playerInput;
    PlayerManager playerManager;

    public Vector2 moveAxis;
    private Vector3 dir;
    public bool isRewinding;
    public bool hasDied;
    private int playerIndex;

    
    public float movementSpeed = 2;
    public float rotationSpeed= 2;
    public float animatorSpeed;
    public float downwardForce;

    

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controls = new Controls();
        animator = GetComponentInChildren<Animator>();
        EL = GetComponent<EffectListener>();
        playerInput = GetComponentInParent<PlayerInput>();
        playerIndex = playerInput.playerIndex;
        playerManager = FindObjectOfType<PlayerManager>();
    }

    public void GetAxis(InputAction.CallbackContext context)
    {
        
        moveAxis = context.ReadValue<Vector2>();
        
        
    }

    private void Update()
    {
        if (playerManager.gameHasStarted)
        {
            PlayersAnimation();
            animatorSpeed = animator.speed;
        }
        
    }

    private void PlayersAnimation()
    {
        animator.SetFloat("Horizontal", moveAxis.x);
        animator.SetFloat("Vertical", moveAxis.y);
    }

    void FixedUpdate()
    {
        if (playerManager.gameHasStarted)
        {
            MovePlayer();
        }
        
        
    }

    public void MovePlayer()
    {
        if (!hasDied)
        {
            if (!isRewinding)
            {
                dir = new Vector3(moveAxis.x, 0, moveAxis.y);

                if (dir != Vector3.zero)
                {
                    Vector3 playersDestination = new Vector3(moveAxis.x, -downwardForce, moveAxis.y);
                    transform.forward = Quaternion.Euler(0, 0, 0) * dir.normalized * movementSpeed;
                    if (rb)
                    {
                        rb.velocity = (playersDestination * movementSpeed);
                    }

                }
                else
                {
                    Vector3 playersDestination = new Vector3(0, -downwardForce, 0);
                    //transform.forward = Quaternion.Euler(0, 0, 0) * dir.normalized * movementSpeed;
                    if (rb)
                    {
                        rb.velocity = (playersDestination * movementSpeed);
                    }

                }

            }
        }
        
        
        
            
    }

    
    

    
    

        

        

        

}
