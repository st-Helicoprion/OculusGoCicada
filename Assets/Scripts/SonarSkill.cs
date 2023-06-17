using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class SonarSkill : MonoBehaviour
{
    
    public GameObject prefab, indicator;
    public Transform playerPos, stickPos, handPos;
    public float frequency;
    public float freqTime, count;
    public TextMeshProUGUI debugText;

    [Header("Circle Checker")]
    public InputActionAsset Controls;
    private InputAction vrInteract;
    public CircleChecker[] checkers;
    public List<int> hitOrder = new List<int>();
    public bool sonarIsActive=false;

    // Start is called before the first frame update
    void Start()
    { 
        var PlayerControls = Controls.FindActionMap("Player");
        vrInteract = PlayerControls.FindAction("VRInteract");
        vrInteract.Enable();

        playerPos = GameObject.Find("XR Origin").GetComponent<Transform>();
        stickPos = GameObject.Find("CicadaStick").GetComponent<Transform>();
        handPos = GameObject.Find("RightHand Controller").GetComponent<Transform>().GetChild(0).GetComponent<Transform>();
        checkers = GameObject.FindObjectsOfType<CircleChecker>();

       
    }

    // Update is called once per frame
    void Update()
    {
        debugText.text = sonarIsActive.ToString();
        //debugText.text = playerPos.gameObject.GetComponent<Rigidbody>().velocity.ToString();
        //debugText.text = frequency.ToString();
        
        freqTime+=Time.deltaTime;
    
       if(hitOrder.Count>4)
        {
            TrackCircle();
             hitOrder.Clear(); 
        }

        Vector3 stickPosSplit = stickPos.position;
        Vector3 handPosSplit = handPos.position;
        if(Mathf.Abs(stickPosSplit.x-handPosSplit.x)<=0.15f
        &&Mathf.Abs(stickPosSplit.y-handPosSplit.y)<=0.15f
        &&Mathf.Abs(stickPosSplit.y-handPosSplit.y)<=0.15f)
        {
            sonarIsActive = true;    
        }
        else sonarIsActive = false;

        Holster();
        
        
    }

    public void SummonSonar()
    {
        Instantiate(prefab, playerPos.position+new Vector3(0,-50f,0),Quaternion.Euler(-90,0,0));
        frequency = 1/freqTime;
        freqTime=0;
        indicator.GetComponent<Animator>().CrossFade("ComfirmSonarAnimation",0);
    }

    public void Holster()
    {
         for(int i =0; i<checkers.Length;i++)
        {
        if(sonarIsActive)
        {    
          checkers[i].gameObject.GetComponent<Collider>().enabled = true;

        }
        else if(!sonarIsActive)
        {
          checkers[i].gameObject.GetComponent<Collider>().enabled = false; 
          
          if(indicator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("IDLE"))
          indicator.GetComponent<Animator>().CrossFade("ComfirmSonarAnimation",0);
        }    
        }
    }

    public void TrackCircle()
    {
           for(int i = 0; i<5; i++)
        {
            if(Mathf.Abs(hitOrder[i]-hitOrder[i+1])==1&&hitOrder[0]==hitOrder[3])
                {
                    SummonSonar();
                    hitOrder.Clear();  
                }
            else return;
           
        }
    }

}
