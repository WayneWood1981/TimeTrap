using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;


public class playerInputHandler : MonoBehaviour
{

    private PlayerMovement playerMovement;

    private PlayerInput playerInput;
    // Start is called before the first frame update
    void Start()
    {
        
        playerInput = GetComponent<PlayerInput>();
        var playerMovements = FindObjectsOfType<PlayerMovement>();
        var index = playerInput.playerIndex;
        //playerMovement = playerMovements.FirstOrDefault(m => m.GetPlayerIndex() == index);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
