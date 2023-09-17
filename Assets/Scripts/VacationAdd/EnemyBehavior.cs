using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    Transform player;
    GameObject PointLight;
    Rigidbody rb;
    [SerializeField]
    float Timer, FlashTime;//用來做閃紅光，預計之後砍掉，用shader或其他方式做
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
        //閃紅光、向玩家移動、動畫
        Vector3 dir = player.localPosition - transform.localPosition;
        // rb.AddForce(dir);
        transform.localPosition += dir * Time.deltaTime;
        // Debug.Log(dir);
        // Vector3.Lerp(player.localPosition,dir,0.1f);
        LightFlash();
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
