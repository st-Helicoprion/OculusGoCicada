using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 [RequireComponent(typeof(AudioSource))]
public class StoryTrigger : MonoBehaviour
{
    public Transform targetPos, currPos;
    public GameObject currMap, targetMap, jumpScare;
    public Image blackScreen;
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
          currPos = other.gameObject.transform;
          Debug.Log("Teleporting...");
          JumpScare();
          Invoke("ReplaceMap", 1f);
          Invoke("MovePlayer", 2f);
          
        }
   }

   public void MovePlayer()
   {
      Color panelColor = blackScreen.color;
      panelColor.a=255;
      
      if(panelColor.a==255)
      {
        currPos.position=targetPos.position;
        panelColor.a=0;
      }
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
}
