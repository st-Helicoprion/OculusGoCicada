using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResoBehavior : MonoBehaviour
{
    public AudioLibrary audioLibAsset;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        ResoEffect();
    }

    public void ResoEffect()
    {
        Debug.Log("hit");
        if(transform.gameObject.CompareTag("Girl")&&audioSource.isPlaying==false)
        {
            audioSource.PlayOneShot(audioLibAsset.effects[Random.Range(1,4)]); 
            
        }

        if(transform.gameObject.CompareTag("Goal")&&audioSource.isPlaying==false)
        {
            audioSource.PlayOneShot(audioLibAsset.effects[0]); 
            
        }
    }
}
