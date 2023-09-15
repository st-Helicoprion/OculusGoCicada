using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Congratulations : MonoBehaviour
{
    public TextMeshProUGUI text, text1;
    public AudioSource audioSource;
    public Image panel;

   private void OnTriggerEnter(Collider other)
   {
     if(other.CompareTag("Player"))
     {
        text.gameObject.SetActive(true); text1.gameObject.SetActive(true);
        text.text = "You have reached the end of our demo\nplease look forward to more good stuff coming\nfrom our team\nThank you very much for playing";
        text1.text = "Press the back button to restart the demo";
        audioSource.Play();
        panel.GetComponent<Animator>().CrossFade("FadeToBlack",0);
        this.gameObject.GetComponent<Renderer>().enabled = false;
     }
   }
}
