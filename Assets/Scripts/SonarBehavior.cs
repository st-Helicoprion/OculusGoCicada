using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarBehavior : MonoBehaviour
{
    public float sonarScale, speed, distance;
    public SonarSkill sonarSkill;
    public float curFreq;
    public Material sonarMat;

    // Start is called before the first frame update
    void Start()
    {
        sonarSkill = GameObject.Find("HitBox").GetComponent<SonarSkill>();
        sonarMat = this.gameObject.GetComponent<Renderer>().material;
        curFreq = sonarSkill.frequency;

        transform.localScale*=sonarScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveUp(); 
    }

    // public void ScaleUp()
    // {
    //      transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(sonarScale, sonarScale, sonarScale), .25f*Time.deltaTime);
    //     if (transform.localScale.x >= sonarScale-1)
    //     {
    //         Destroy(this.gameObject);
    //     }
    // }

    public void MoveUp()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        distance += speed*Time.deltaTime;
        Color sonarColor = sonarMat.color;
        sonarColor.r-= .05f*Time.deltaTime;
        sonarColor.g-= .05f*Time.deltaTime;
        sonarColor.b-= .05f*Time.deltaTime;
        sonarMat.color = sonarColor;
        if(sonarMat.color.r<=0)
        {
            sonarColor.r = 0;
            sonarMat.color = sonarColor;
        }
        if (distance >= sonarScale*2)
        {
            Destroy(this.gameObject);
            distance=0;
        }
    }
    
}
