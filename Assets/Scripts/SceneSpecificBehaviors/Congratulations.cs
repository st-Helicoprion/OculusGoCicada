using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Congratulations : MonoBehaviour
{
    public TextMeshProUGUI text;
    public AudioSource audioSource;
    public Image panel;

   private void OnTriggerEnter(Collider other)
   {
     if(other.CompareTag("Player"))
     {
        text.text = "You have reached the end of our demo\nplease look forward to more good stuff coming\nfrom our team";
        audioSource.Play();
        Color panelColor = panel.color;
        panelColor.a += 0.25f*Time.deltaTime;
        panel.color = panelColor;
     }
   }
}
