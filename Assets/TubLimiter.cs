using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TubLimiter : MonoBehaviour
{
    public ConfigurableJoint jointLock;
    public TextMeshProUGUI debugText;
    public Rigidbody rb;
    public GameObject stickTop;
    public bool isSpin = false;

    void Start()
    {
        jointLock = GetComponent<ConfigurableJoint>();
        rb =  GetComponent<Rigidbody>();
    }
    void Update()
    {
        //joint1.zMotion = ConfigurableJointMotion.Free;

        // debugText.text = rb.velocity.ToString();

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
        }
        else jointLock.zMotion = ConfigurableJointMotion.Free;

    }
}
