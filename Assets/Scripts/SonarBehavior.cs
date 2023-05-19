using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarBehavior : MonoBehaviour
{
    public Transform SonarScale;
    public SonarSkill SonarSkill;
    public float curFreq;
    public float sonarSize;

    // Start is called before the first frame update
    void Start()
    {
        SonarSkill = GameObject.Find("HitBox").GetComponent<SonarSkill>();

        curFreq = SonarSkill.frequency;
    }

    // Update is called once per frame
    void Update()
    {
        SonarScale.localScale = Vector3.Lerp(SonarScale.localScale, new Vector3(sonarSize, sonarSize, sonarSize), .5f*Time.deltaTime);
        if (SonarScale.localScale.x >= sonarSize-1)
        {
            Destroy(this.gameObject);
        }

    }
}
