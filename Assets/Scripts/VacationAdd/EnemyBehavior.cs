using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyBehavior : MonoBehaviour
{
    Transform player;
    GameObject PointLight;

    [SerializeField]
    Animator animator;

    Rigidbody rb;
    [SerializeField]
    float Timer, FlashTime, Speed = 0.5f;//用來做閃紅光，預計之後砍掉，用shader或其他方式做
    void Start()
    {
        player = GameObject.Find("XR Origin").transform;
        PointLight = transform.Find("Point Light").gameObject;
        PointLight.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider collider)
    {
        Vector3 dir = player.localPosition - transform.localPosition;
        transform.localPosition += dir * Time.deltaTime * Speed;
        Debug.Log("HIT");
        transform.rotation=Quaternion.LookRotation(-dir);
        // Vector3.Lerp(player.localPosition,dir,0.1f);
        LightFlash();
        if (animator.GetBool("Chasing") != true)
        {
            animator.SetBool("Chasing", true);
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (animator.GetBool("Chasing") != false)
        {
            animator.SetBool("Chasing", false);
        }
    }
    void FixedUpdate()
    {
        if (Timer > 0)
        {
            Timer--;
        }
        if (Timer < FlashTime)
        {
            PointLight.SetActive(false);
        }
    }

    void LightFlash()
    {
        PointLight.SetActive(true);
        if (Timer > FlashTime + 10)
        {
            Timer = Timer + 2;
        }
    }
}
