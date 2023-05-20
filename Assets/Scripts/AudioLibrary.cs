using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AudioLibrary : ScriptableObject
{
   public List<AudioClip> songs = new List<AudioClip>();
   public List<AudioClip> effects = new List<AudioClip>();
   public List<AudioClip> dialogues = new List<AudioClip>();
   
   
}
