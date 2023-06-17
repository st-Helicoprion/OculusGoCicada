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

    public AudioSource audioSource; public AudioLibrary audioLibAsset;
    private Rigidbody rb;
    public Vector2 speed;
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
        
        sonarSkill = GameObject.Find("HitBox").GetComponent<SonarSkill>();
        audioSource = GetComponent<AudioSource>();
        audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveDir = move.ReadValue<Vector2>();
        Quaternion curVRRot = vrLook.ReadValue<Quaternion>();
        float startRun = run.ReadValue<float>();
      
        if(isLaptop==true)
       {
        rb.velocity = 1.75f*transform.forward*moveDir.y*speed.x+transform.right*moveDir.x*speed.x+-transform.up*speed.x/2;
        if(!audioSource.isPlaying&&moveDir.x!=0&&startRun==0||!audioSource.isPlaying&&moveDir.y!=0&&startRun==0)
        audioSource.PlayOneShot(audioLibAsset.effects[8]);
       }
       else
       {
        Camera.localRotation = new Quaternion(0,curVRRot.y,0,curVRRot.w);
        transform.localRotation = new Quaternion(0,curVRRot.y,0,curVRRot.w);
        rb.velocity =1.75f*Camera.forward*moveDir.y*speed.x+Camera.right*moveDir.x*speed.x+-transform.up*speed.x/2;
       if(!audioSource.isPlaying&&moveDir.x!=0&&startRun==0||!audioSource.isPlaying&&moveDir.y!=0&&startRun==0)
        audioSource.PlayOneShot(audioLibAsset.effects[8]);
       }

       if(startRun==1)
       {
        if(isLaptop)
        {
            rb.velocity =transform.forward*startRun*speed.y+-transform.up*speed.x/2;
            if(!audioSource.isPlaying)
         audioSource.PlayOneShot(audioLibAsset.effects[9]);
        
        }
        else
        rb.velocity =Camera.forward*startRun*speed.y+-transform.up*speed.x/2;
        if(!audioSource.isPlaying)
        audioSource.PlayOneShot(audioLibAsset.effects[9]);
       }

        float clicky = interact.ReadValue<float>();
        float restart = replay.ReadValue<float>();
        
        if(clicky!=0&&!isSonar)
        {
        Laptop.enabled = true;
        isLaptop = true;
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
