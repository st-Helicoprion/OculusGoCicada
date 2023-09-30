using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer==11)
        {
            isGrounded = true;

        }
       
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.layer==11)
        {
            isGrounded = false;
           
        }
    }

}
