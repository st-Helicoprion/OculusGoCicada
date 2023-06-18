using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FirstForestRoad : MonoBehaviour
{
    public Transform player, target;
    public NavMeshAgent agent;
    public Animator anim;
    public float distance;
    public SkinnedMeshRenderer skin;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
      
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.position, agent.transform.position);

        if(distance<10)
        {
            agent.speed = 5;
            agent.SetDestination(target.position);
            if(!anim.GetCurrentAnimatorStateInfo(0).IsName("RUN"))
            anim.CrossFade("RUN",0);
            agent.transform.LookAt(target.position);
            
        }
        else if (distance>15&&distance<20)
        {  
           skin.enabled = true;
            agent.speed = 0;
            agent.transform.LookAt(player.position);
             if(!anim.GetCurrentAnimatorStateInfo(0).IsName("WAVING"))
            anim.CrossFade("WAVING",0);
        }
        else if(distance>20)
        {
            skin.enabled = true;
             agent.speed = 5;
            agent.SetDestination(player.position);
             if(!anim.GetCurrentAnimatorStateInfo(0).IsName("RUN"))
            anim.CrossFade("RUN",0);
            agent.transform.LookAt(player.position);
        }

        if(agent.transform.position==target.position&&distance<15)
        {
            skin.enabled = false;
            agent.speed = 0;
            agent.transform.LookAt(player.position);
            
        }


    }
}
