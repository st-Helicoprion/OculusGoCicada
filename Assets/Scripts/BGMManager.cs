using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BGMManager : MonoBehaviour
{
    public AudioLibrary audioLibAsset;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioLibAsset = Resources.Load<AudioLibrary>("AudioLibAsset");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(audioLibAsset.songs[Random.Range(0,audioLibAsset.songs.Count)]);
        }

    }
    
}
