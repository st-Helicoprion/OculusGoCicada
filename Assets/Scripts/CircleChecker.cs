using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 這份程式，目前的作用是把Checker的ID送給SonarSkill.hitOrder，總覺得可以寫個return解決掉
public class CircleChecker : MonoBehaviour
{
    [SerializeField]
    int id;
    SonarSkill sonarSkill;

    void Start()
    {
        sonarSkill = GameObject.FindObjectOfType<SonarSkill>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Buzz"))
        {
            sonarSkill.hitOrder.Add(id);
            //     for(int i = 0; i<sonarSkill.hitOrder.Count; i++)
            // {
            //     Debug.Log(sonarSkill.hitOrder[i]);
            // }
        }
    }
}
