using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{



    PlayerActions playerActions;
    SphereController sphereController;
    PlayerController playerController;

    [Header("Keyboard Inputs")]
    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    [Header("Mouse Inputs")]
    public Vector2 cameraInput;
    public float cameraInputX;
    public float cameraInputY;

    public bool b_Input;
    public bool spaceInput;

    private void Awake()
    {
        sphereController = GetComponent<SphereController>();
    }

    private void OnEnable()
    {
        if (playerActions == null)
        {
            playerActions = new PlayerActions();
            //this gets the values from the player actions, goes to the action I added, to the movement and then checks for a performed vec2 action 
            playerActions.PlayerControls.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerActions.PlayerControls.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();

            playerActions.PlayerAbilities.B.performed += i => b_Input = true;
            playerActions.PlayerAbilities.B.canceled += i => b_Input = false;

            playerActions.PlayerAbilities.Jump.performed += i => spaceInput = true;



        }

        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }

    /// <summary>
    /// This is just for encapsulation purposes, it means that the other functions can remain private and it is easier to call from other scripts. 
    /// </summary>
    public void HandleAllInputs()
    {
        HandleMovementInput();
        HandleJumpInput();
        //HandleRollInput();
    }


    /// <summary>
    /// This takes the input from the player actions and splits them into two varibles to be used in for the player controller
    /// </summary>
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

        cameraInputY = cameraInput.y;
        cameraInputX = cameraInput.x;
    }

    private void HandleJumpInput()
    {
        if(spaceInput)
        {
            spaceInput = false;
            sphereController.Jump();
        }
    }
}
