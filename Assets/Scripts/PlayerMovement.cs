using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset Controls;
    public Transform Camera;
    private InputAction move, interact, vrLook, run;

    private Rigidbody rb;
    public float speed;
    public SonarSkill sonarSkill; public ForLaptopDev Laptop;
    public bool isSonar=false, isLaptop;
    // Start is called before the first frame update
    void Start()
    {   
        rb=GetComponent<Rigidbody>();
        Laptop = GetComponent<ForLaptopDev>();
        
        var PlayerControls = Controls.FindActionMap("Player");
        move = PlayerControls.FindAction("Move");
        interact = PlayerControls.FindAction("Interact");
        vrLook = PlayerControls.FindAction("VRLook");
        run = PlayerControls.FindAction("Run");
        move.Enable(); interact.Enable(); vrLook.Enable(); run.Enable();

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveDir = move.ReadValue<Vector2>();
        Quaternion curVRRot = vrLook.ReadValue<Quaternion>();
        float startRun = run.ReadValue<float>();
      

        Debug.Log(curVRRot);
        if(isLaptop==true)
       {
        rb.velocity =transform.forward*moveDir.y*speed+transform.right*moveDir.x*speed;
       }
       else
       {
        Camera.localRotation = new Quaternion(0,curVRRot.y,0,curVRRot.w);
        transform.localRotation = new Quaternion(0,curVRRot.y,0,curVRRot.w);
        rb.velocity =Camera.forward*moveDir.y*speed+Camera.right*moveDir.x*speed;
       }

       if(startRun==1)
       {
        speed = 4;
        rb.velocity =Camera.forward*startRun*speed;
       }else speed=2.5f;

        float clicky = interact.ReadValue<float>();
        
        if(clicky!=0&&!isSonar)
        {
        Laptop.enabled = true;
        isLaptop = true;
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
