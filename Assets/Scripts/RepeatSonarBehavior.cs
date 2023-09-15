using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatSonarBehavior : MonoBehaviour
{
    public GameObject limitSonar;
    public RepeatingSonar repeatSonar;
    public float moveSpeed = 5, fadingSpeed;
    private void Start()
    {
        repeatSonar = GameObject.FindObjectOfType<RepeatingSonar>();
      
    }
    // Update is called once per frame
    void Update()
    {
        limitSonar = repeatSonar.limitSonar;
        this.transform.position = limitSonar.transform.position;
        EnlargeToLimits();
        if (this.transform.localScale.x >= limitSonar.transform.localScale.x)
        {
            Destroy(this.gameObject);
        }
    }

    public void EnlargeToLimits()
    {
        this.transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * moveSpeed;
        Material sonarMat = this.gameObject.GetComponent<Renderer>().material;
        Color sonarColor = sonarMat.color;
        fadingSpeed = 2.5f*Time.deltaTime / limitSonar.transform.localScale.x;

        sonarColor.r -= fadingSpeed;
        sonarColor.g -= fadingSpeed;
        sonarColor.b -= fadingSpeed;

        sonarMat.color = sonarColor;

        this.transform.position = limitSonar.transform.position;

        
    }
}
