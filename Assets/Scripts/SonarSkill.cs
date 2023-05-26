using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SonarSkill : MonoBehaviour
{
    public AudioLibrary audioLibAsset;
    public AudioSource audioSource;
    public GameObject prefab;
    public Transform playerPos, stickPos;
    public float frequency;
    public float freqTime, count;

    [Header("Circle Checker")]
    public InputActionAsset Controls;
    private InputAction vrInteract;
    public CircleChecker[] checkers;
    public List<int> hitOrder = new List<int>();

    // Start is called before the first frame update
    void Start()
    { 
        var PlayerControls = Controls.FindActionMap("Player");
        vrInteract = PlayerControls.FindAction("VRInteract");
        vrInteract.Enable();

        playerPos = GameObject.Find("XR Origin").GetComponent<Transform>();
        stickPos = GameObject.Find("ObiLinePivot").GetComponent<Transform>();
        checkers = GameObject.FindObjectsOfType<CircleChecker>();

        audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Holster();
        
        freqTime+=Time.deltaTime;
    
       if(hitOrder.Count>4)
        {
            TrackCircle();
             hitOrder.Clear(); 
        }
    }

    public void SummonSonar()
    {
         Instantiate(prefab, playerPos.position+new Vector3(0,-20f,0),Quaternion.identity);
          frequency = freqTime;
            freqTime=0;
    }

    public void Holster()
    {
         float triggy = vrInteract.ReadValue<float>();
        

         for(int i =0; i<checkers.Length;i++)
        {
        if(triggy==1)
        {      
             checkers[i].gameObject.GetComponent<Collider>().enabled = true;
             //count=0;
        }
        else if(triggy==0)
        checkers[i].gameObject.GetComponent<Collider>().enabled = false;
        // count+=Time.deltaTime;
        // if(count>=4)
        // {
        //     audioSource.Stop();
        //     count=0;
        // }
           
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
                    //if(audioSource.isPlaying==false)
                    //audioSource.PlayOneShot(audioLibAsset.effects[5],0.5f);
                }
                //else audioSource.Stop();
            else return;
           
        }
    }

}
