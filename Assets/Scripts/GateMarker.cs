using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMarker : MonoBehaviour
{
    public int gateID;
    public Animator anim;
    public StoryManager storyManager;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        storyManager = GameObject.Find("StoryManager").GetComponent<StoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(storyManager.stagesCompleted==gateID)
        {
            anim.SetTrigger("Completed");
        }
    }
}
