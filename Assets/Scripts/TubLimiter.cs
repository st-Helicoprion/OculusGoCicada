using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TubLimiter : MonoBehaviour
{
    public ConfigurableJoint jointLock;
    public TextMeshProUGUI debugText;
    public Rigidbody rb;
    public GameObject stickPos, handPos, visual, stickTop;
    public bool isSpin = false;
    // public Rigidbody playerRB;
    public AudioLibrary audioLibAsset;
    public AudioSource audioSource;
    public SonarSkill playerState;
    void Start()
    {
        jointLock = GetComponent<ConfigurableJoint>();
        rb =  GetComponent<Rigidbody>();
        //playerRB好像沒有用途?
        // playerRB = GameObject.Find("XR Origin").GetComponent<Rigidbody>();
        audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
        audioSource = GameObject.Find("HitBox").GetComponent<AudioSource>();
        playerState = GameObject.Find("HitBox").GetComponent<SonarSkill>();
    }
    void Update()
    {
        //debugText.text = stickPos.transform.position.ToString() + "," + handPos.transform.position.ToString() ;
        //debugText.text = playerRB.velocity.ToString();
        //debugText.text = (Time.frameCount/Time.time).ToString();

        visual.transform.position = Vector3.Lerp(visual.transform.position,transform.position,1);
        visual.transform.LookAt(stickTop.transform.position);

        if(Mathf.Abs(rb.velocity.x)>3)
        {
            isSpin=true;
        }
        else if(Mathf.Abs(rb.velocity.y)>3)
        {
            isSpin = true;
        }
         else if(Mathf.Abs(rb.velocity.z)>3)
        {
            isSpin = true;
        } else isSpin=false;

        if(isSpin)
        {
            jointLock.zMotion = ConfigurableJointMotion.Locked;
            if(audioSource.volume<=1f)
            {
            audioSource.volume+=0.25f*Time.deltaTime;
            //audioSource另開一份Script管理
            if(!audioSource.isPlaying&&playerState.sonarIsActive)
            audioSource.PlayOneShot(audioLibAsset.effects[5]);
            }
        }
        else 
        {
            jointLock.zMotion = ConfigurableJointMotion.Free;
              audioSource.volume-=0.25f*Time.deltaTime;
              if(audioSource.volume<=0)
              {
                audioSource.Stop();
              }
        }

    }
}
