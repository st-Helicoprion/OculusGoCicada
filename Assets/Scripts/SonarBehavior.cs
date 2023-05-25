using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarBehavior : MonoBehaviour
{
    public float sonarScale, speed, distance;
    public SonarSkill SonarSkill;
    public float curFreq;

    // Start is called before the first frame update
    void Start()
    {
        SonarSkill = GameObject.Find("HitBox").GetComponent<SonarSkill>();

        curFreq = SonarSkill.frequency;

        transform.localScale*=sonarScale;
    }

    // Update is called once per frame
    void Update()
    {
       
        MoveUp();
    }

    public void ScaleUp()
    {
         transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(sonarScale, sonarScale, sonarScale), .25f*Time.deltaTime);
        if (transform.localScale.x >= sonarScale-1)
        {
            Destroy(this.gameObject);
        }
    }

    public void MoveUp()
    {
        
        transform.position += Vector3.up * speed * Time.deltaTime;
        distance += speed*Time.deltaTime;
        if (distance >= sonarScale/2)
        {
            Destroy(this.gameObject);
            distance=0;
        }
    }
    
}
