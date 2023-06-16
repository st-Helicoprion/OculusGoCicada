using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public GameObject particle;


    // Start is called before the first frame update
    void Start()
    {
        audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
        audioSource = GetComponent<AudioSource>();
        playerAudSource = GameObject.Find("XR Origin").GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

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


    public void ResoEffect()
    {
        if(transform.gameObject.CompareTag("Light"))
        {
            anim.CrossFade("Glow", 0f);
            audioSource.PlayOneShot(audioLibAsset.effects[7],.25f);
            playerAudSource.PlayOneShot(audioLibAsset.effects[6],.25f);
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

                    ResoEffect();
                    isActivated=true;
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

                    ResoEffect();
                    isActivated=true;
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

        if(transform.gameObject.CompareTag("Goal")&&audioSource.isPlaying==false)
        {
            audioSource.PlayOneShot(audioLibAsset.effects[0]); 
            
        }
    }

    public void ShowLayerHit()
    {
        Instantiate(particle, transform.position,Quaternion.identity);
    }
    
}
