using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTrigger : MonoBehaviour
{
    public Transform targetPos, currPos;
    public GameObject currMap, targetMap;
    public Image blackScreen;
   private void OnTriggerEnter(Collider other)
   {
        currPos.position = other.gameObject.transform.position;
   }

   public void MovePlayer()
   {
      Color panelColor = blackScreen.color;
      panelColor.a-=0.25f*Time.deltaTime;
      
      currPos.position=targetPos.position;

      if(panelColor.a<=0)
      {
        panelColor.a+=0.25f*Time.deltaTime;
      }
   }

   public void ReplaceMap()
   {
     currMap.SetActive(false); targetMap.SetActive(true);
   }
}
