using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ForLaptopDev : MonoBehaviour
{
    public InputActionAsset Controls;
    private InputAction look;
    public Transform mainCamera;
    public float rotSpeed;

    public Vector2 turn;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;        

         var PlayerControls = Controls.FindActionMap("Player");
         look = PlayerControls.FindAction("Look");
        
         look.Enable();
        mainCamera = GameObject.Find("XR Origin").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    //    Vector2 lookDir = look.ReadValue<Vector2>();

    //    Debug.Log("MouseX:"+lookDir.x+", MouseY:"+lookDir.y);

    //   mainCamera.Rotate(new Vector3(-lookDir.y, lookDir.x, 0)*rotSpeed,Space.Self);

       Vector2 lookDir = look.ReadValue<Vector2>();
    
        turn.x += lookDir.x;
        turn.y += lookDir.y;
       mainCamera.localRotation = Quaternion.Euler(-turn.y*rotSpeed, turn.x*rotSpeed,0);
    }

}
