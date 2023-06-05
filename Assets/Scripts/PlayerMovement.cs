using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset Controls;
    public Transform Camera;
    private InputAction move, interact, vrLook, run, replay;

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
        replay = PlayerControls.FindAction("Replay");
        move.Enable(); interact.Enable(); vrLook.Enable(); run.Enable();
        replay.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveDir = move.ReadValue<Vector2>();
        Quaternion curVRRot = vrLook.ReadValue<Quaternion>();
        float startRun = run.ReadValue<float>();
      
        if(isLaptop==true)
       {
        rb.velocity =transform.forward*moveDir.y*speed+transform.right*moveDir.x*speed+-transform.up*speed/2;
       }
       else
       {
        Camera.localRotation = new Quaternion(0,curVRRot.y,0,curVRRot.w);
        transform.localRotation = new Quaternion(0,curVRRot.y,0,curVRRot.w);
        rb.velocity =Camera.forward*moveDir.y*speed+Camera.right*moveDir.x*speed+-transform.up*speed/2;
       }

       if(startRun==1)
       {
        speed = 5;
        if(isLaptop)
        {
            rb.velocity =transform.forward*startRun*speed+-transform.up*speed/2;
        }
        else
        rb.velocity =Camera.forward*startRun*speed+-transform.up*speed/2;
       }else speed=3f;

        float clicky = interact.ReadValue<float>();
        float restart = replay.ReadValue<float>();
        
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

        if(restart==1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


     
                
    }
}
