using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResoBehavior : MonoBehaviour
{
    public AudioLibrary audioLibAsset;
    public AudioSource audioSource, playerAudSource;
    public Animator anim;

    public enum freqRange {high, low};

    public freqRange setFreq;
    public bool isActivated = false, extra;
    public int resoLayer;
    SonarBehavior sonarBehavior;
    float curFreq;
    public GameObject particle, heldItem; 
    public StoryManager storyManager;


    // Start is called before the first frame update
    void Start()
    {
        audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
        audioSource = GetComponent<AudioSource>();
        playerAudSource = GameObject.Find("XR Origin").GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        storyManager = GameObject.Find("XR Interaction Manager").GetComponent<StoryManager>();

        audioSource.spatialBlend =1;
        audioSource.maxDistance = 50;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sonar"))
        {
            other.tag = "Untagged";
            sonarBehavior = other.GetComponent<SonarBehavior>();
            curFreq = sonarBehavior.curFreq;
            if(!extra)
            FreqCheck();
            else
            ExtraResoEffect();

        }
       
    }

    private void OnTriggerStay(Collider other)
    {
         if(other.CompareTag("KeyItem"))
        {
            anim = other.gameObject.GetComponent<Animator>();
        }
    }


    public void ResoEffect()
    {
        if(transform.gameObject.CompareTag("Light"))
        {
            anim.CrossFade("Glow", 0f);
            audioSource.PlayOneShot(audioLibAsset.effects[7]);
            playerAudSource.PlayOneShot(audioLibAsset.effects[6]);
            if(heldItem!=null)
            {
                Instantiate(heldItem,transform.position+new Vector3(-1,1,-1),Quaternion.identity);
            }
            else return;
        }

        if(transform.gameObject.CompareTag("KeyBox"))
        {
           if(anim)
           {
                anim.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                transform.GetComponent<XRSocketInteractor>().enabled = false;
                anim.SetTrigger("Unlock");
                storyManager.stagesCompleted++;
                
           }
           else if(!anim) 
           {
            resoLayer=0;
            isActivated=false;
           }
        }
    }

    public void FreqCheck()
    {
        if(setFreq == freqRange.low&&!isActivated)
        {
            if(audioSource.isPlaying==false)
            {
                audioSource.PlayOneShot(audioLibAsset.mechanics[0]);
                if(curFreq<0.5)
                {
                    resoLayer++;
                    ShowLayerHit();
                    if(resoLayer==3)
                    {

                    isActivated=true;
                    ResoEffect();
                    }
                }
            }
        }
      
        else if(setFreq == freqRange.high&&!isActivated)
        {
            if(audioSource.isPlaying==false)
            {
                audioSource.PlayOneShot(audioLibAsset.mechanics[1]);
                if(curFreq>1)
                {
                    resoLayer++;
                    ShowLayerHit();
                    if(resoLayer==3)
                    {

                    isActivated=true;
                    ResoEffect();
                    }
                }
            }
        }
    }
    public void ExtraResoEffect()
    {
        Debug.Log("extra hit");
        if(transform.gameObject.CompareTag("Girl")&&audioSource.isPlaying==false)
        {
            audioSource.PlayOneShot(audioLibAsset.effects[Random.Range(1,4)]); 
            
        }
    }

    public void ShowLayerHit()
    {
        Instantiate(particle, transform.position,Quaternion.identity);
    }
    
}
