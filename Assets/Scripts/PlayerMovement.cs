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
    public SonarSkill sonarSkill;
    public bool isSonar=false;

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
        Vector2 moveDir = move.ReadValue<Vector2>();
        rb.velocity =Camera.forward*moveDir.y*speed+Camera.right*moveDir.x*speed;

        float clicky = interact.ReadValue<float>();
        
        if(clicky!=0&&!isSonar)
        {
        sonarSkill = Transform.FindObjectOfType<SonarSkill>();
        sonarSkill.SummonSonar();
        isSonar=true;
        }
        if(clicky==0)
        {
            isSonar = false;
        }

     
                
    }
}
