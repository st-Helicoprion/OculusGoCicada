using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleChecker : MonoBehaviour
{
    public int id;
    public SonarSkill sonarSkill;
    
   void Start() 
   {
      sonarSkill = GameObject.FindObjectOfType<SonarSkill>();

   }

   private void OnTriggerEnter(Collider other)
   {
        if(other.gameObject.CompareTag("Buzz"))
        {
           sonarSkill.hitOrder.Add(id);
        //     for(int i = 0; i<sonarSkill.hitOrder.Count; i++)
        // {
        //     Debug.Log(sonarSkill.hitOrder[i]);
        // }
       }
   }
}
