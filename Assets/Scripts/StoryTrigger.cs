using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 [RequireComponent(typeof(AudioSource))]
public class StoryTrigger : MonoBehaviour
{
    public enum triggerFunctions {teleport, teleportAndScare, ambience};
    public triggerFunctions setFunction;
    public Transform targetPos, currPos;
    public GameObject currMap, targetMap, jumpScare;
    public AudioClip jumpScareSound;
    public AudioSource triggerAudSource;

  void Start()
  {
    triggerAudSource = GetComponent<AudioSource>();
  }

   private void OnTriggerEnter(Collider other)
   {
        if(other.gameObject.CompareTag("Player"))
        {
          if(setFunction==triggerFunctions.teleportAndScare)
          {
            currPos = other.gameObject.transform;
            Debug.Log("Teleporting...");
            JumpScare();
            Invoke("ReplaceMap", 1f);
            Invoke("MovePlayer", 2f);
          }

          if(setFunction==triggerFunctions.teleport)
          {
            Debug.Log("Teleporting...");
            Invoke("ReplaceMap", 1f);
            Invoke("MovePlayer", 2f);
          }
          
          if(setFunction==triggerFunctions.ambience)
          {
            Debug.Log("Event entered");
            EventEntered();
          }
        }
   }

   public void MovePlayer()
   {
      currPos.position=targetPos.position;
      currPos.gameObject.GetComponent<Rigidbody>().isKinematic = false;
   }

   public void ReplaceMap()
   {
     currPos.gameObject.GetComponent<Rigidbody>().isKinematic = true;
     currMap.SetActive(false); targetMap.SetActive(true);
   }

   public void JumpScare()
   {
      currPos.gameObject.GetComponent<Rigidbody>().isKinematic = true;
      jumpScare.SetActive(true);
      triggerAudSource.PlayOneShot(jumpScareSound);
   }

   public void EventEntered()
   {
      triggerAudSource.PlayOneShot(jumpScareSound);
      this.gameObject.GetComponent<Collider>().enabled = false;
   }
}
