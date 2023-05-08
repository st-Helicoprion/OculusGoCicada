using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarSkill : MonoBehaviour
{
    public GameObject prefab;
    public Transform playerPos;
    public float frequency, disableAnim;
    // public Animator toyAnim;
   // public bool startCount;
    // public AudioSource AudioSource;
    // public AudioClip toyNoise;

    // Start is called before the first frame update
    void Start()
    { 
        playerPos = GameObject.Find("XR Origin").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (frequency <= 0)
        {
            frequency = 0;
        }
        else frequency -= 0.5f*Time.deltaTime;
    
      

        // if(Input.GetMouseButtonDown(0))
        // {

        //     if(AudioSource.isPlaying==false)
        //     {
        //         AudioSource.PlayOneShot(toyNoise);
        //     }
        //     toyAnim.enabled = true;
        //     toyAnim.CrossFade("DeformBoneAction", 0.5f);
        //     startCount = true;
        // }

        // if(startCount==true)
        // {
        //     disableAnim += Time.deltaTime;

        // }

        // if(disableAnim>=4)
        // {
        //     startCount = false;
        //     disableAnim = 0;
        //     toyAnim.enabled = false;
        //     AudioSource.Stop();

        // }


    }

    public void SummonSonar()
    {
         Instantiate(prefab, playerPos.position,Quaternion.identity);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Buzz"))
        {
        Instantiate(prefab, playerPos.position,Quaternion.identity);
            frequency++;
        }
    }
}
