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
    public Rigidbody playerRB;
    public AudioLibrary audioLibAsset;
    public AudioSource audioSource;

    void Start()
    {
        jointLock = GetComponent<ConfigurableJoint>();
        rb =  GetComponent<Rigidbody>();
        playerRB = GameObject.Find("XR Origin").GetComponent<Rigidbody>();
         audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
        audioSource = GameObject.Find("HitBox").GetComponent<AudioSource>();
    }
    void Update()
    {
        //debugText.text = stickPos.transform.position.ToString() + "," + handPos.transform.position.ToString() ;
        //debugText.text = playerRB.velocity.ToString();

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
            if(audioSource.volume<=0.5f)
            {
            audioSource.volume+=0.25f*Time.deltaTime;

            if(audioSource.isPlaying==false)
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
