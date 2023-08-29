using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMarker : MonoBehaviour
{
    public int gateID;
    public Animator anim;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public StoryManager storyManager;
    public bool isActivated=false;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        storyManager = GameObject.Find("XR Interaction Manager").GetComponent<StoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(storyManager.stagesCompleted==gateID)
        {
            anim.SetTrigger("Completed");
            if(!audioSource.isPlaying&&isActivated==false)
            audioSource.PlayOneShot(audioClip);
            isActivated=true;
        }
    }
}
