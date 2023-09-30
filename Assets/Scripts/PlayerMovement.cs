using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

//這份script做了太多事情，要拆開
public class PlayerMovement : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioLibrary audioLibAsset;
    public Rigidbody rb;
    public SonarSkill sonarSkill;
    public ForLaptopDev Laptop;
    public Transform Camera;
    public InputReader inputReader;
    public GroundCheck groundCheck;
    public Vector2 speed;
    GameObject DirLight;
    Vector2 MoveDir;
    public bool isSonar = false, isLaptop;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Laptop = GetComponent<ForLaptopDev>();
        sonarSkill = GameObject.Find("HitBox").GetComponent<SonarSkill>();
        audioSource = GetComponent<AudioSource>();
        audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
        inputReader = Resources.Load<InputReader>("Input Reader Prefab");
        DirLight=GameObject.Find("Directional Light");
        SetEvents();
    }
    void Update()
    {
        Move(MoveDir);
    }
    void SetEvents()
    {
        //player
        inputReader.InteractEvent += MouseClicked;
        inputReader.MoveEvent += MoveEventHandle;
        inputReader.RunEvent += Run;
        inputReader.VRLookEvent += VRRotation;
        //test
        inputReader.ReplayEvent += RePlay;
        inputReader.TurnLightOff += TurnLightOff;
    }

    void MoveEventHandle(Vector2 TempMoveDir)
    {
        MoveDir = TempMoveDir;
        // Debug.Log("MoveEventInvoke");
    }
    void Move(Vector2 moveDir)
    {
        Debug.Log("vr walk havent made,add more player action");
        if (groundCheck.isGrounded)
        {
            rb.velocity = 1.75f * transform.forward * moveDir.y * speed.x + transform.right * moveDir.x * speed.x;
        }
        else if(!groundCheck.isGrounded)
        {
            rb.velocity = 1.75f * transform.forward * moveDir.y * speed.x + transform.right * moveDir.x * speed.x + -transform.up * speed.x;

        }
    }
    void VRRotation(Quaternion curVRRot)
    {
        Camera.localRotation = new Quaternion(0, curVRRot.y, 0, curVRRot.w);
        transform.localRotation = new Quaternion(0, curVRRot.y, 0, curVRRot.w);
    }
    void WalkSFX()
    {
        // if (!audioSource.isPlaying && moveDir.x != 0 && RunSpeed == 0 || !audioSource.isPlaying && moveDir.y != 0 && RunSpeed == 0)
        //     audioSource.PlayOneShot(audioLibAsset.effects[8]);
    }

    void MouseClicked()
    {
        if (Laptop != null)
        {
            Laptop.enabled = true;
        }
        else
        {
            Debug.Log("Laptop==null");
        }
        isLaptop = true;
        //感覺為了SummonSonar就把sonarSkill叫進來有點浪費
        //這裡應該是為了電腦版運作才有這行
        sonarSkill.SummonSonar();
        isSonar = true;
    }

    void Run(InputActionPhase phase)
    {
        if (phase == InputActionPhase.Performed)
        {

            if (isLaptop)
            {
                rb.velocity = transform.forward * speed.y;
                if (!audioSource.isPlaying)//有空再來移這個
                    audioSource.PlayOneShot(audioLibAsset.effects[9]);
            }
            else
                rb.velocity = Camera.forward * speed.y;
            if (!audioSource.isPlaying)
                audioSource.PlayOneShot(audioLibAsset.effects[9]);
        }
    }
    void RePlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void TurnLightOff()
    {
        DirLight.SetActive(!DirLight.active);
    }
}
