using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset Controls;
    public Transform Camera;
    private InputAction move, interact;

    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {   
        rb=GetComponent<Rigidbody>();

        var PlayerControls = Controls.FindActionMap("Player");
        move = PlayerControls.FindAction("Move");
        interact = PlayerControls.FindAction("Interact");
        move.Enable(); interact.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDir = move.ReadValue<float>();

        if(moveDir!=0)
        {
            rb.velocity = Camera.forward*moveDir*speed;
        }
    }
}
