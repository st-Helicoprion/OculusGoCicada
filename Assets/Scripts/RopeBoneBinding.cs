using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RopeBoneBinding : MonoBehaviour
{
    public HingeJoint[] bones;
    public Rigidbody[] boneRB;
    public HingeJoint toStickBone;
    public Rigidbody stickBone;
    

    // Start is called before the first frame update
    void Start()
    {
        bones = GetComponentsInChildren<HingeJoint>();  
        stickBone = GameObject.Find("LinePivot").GetComponent<Rigidbody>();
        BindOnEntry();
       
    }

    // Update is called once per frame
    void Update()
    {
        toStickBone.connectedBody = stickBone;
        toStickBone.transform.position = stickBone.transform.position;
        Debug.Log(boneRB[2].solverIterations);
    }

    public void BindOnEntry()
    {
        boneRB = GetComponentsInChildren<Rigidbody>();
        for(int i =0; i<bones.Length-1;i++)
        {
            bones[i].connectedBody = boneRB[i+1]; 
            boneRB[i].solverIterations = 20;
        }
    
    }
}
