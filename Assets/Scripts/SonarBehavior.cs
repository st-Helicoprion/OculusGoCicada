using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarBehavior : MonoBehaviour
{
    public Transform SonarScale;
    public SonarSkill SonarSkill;
    public float curFreq;

    // Start is called before the first frame update
    void Start()
    {
        SonarSkill = GameObject.Find("HitBox").GetComponent<SonarSkill>();

        curFreq = SonarSkill.frequency;
    }

    // Update is called once per frame
    void Update()
    {
        SonarScale.localScale = Vector3.Lerp(SonarScale.localScale, new Vector3(10, 10, 10), .5f*Time.deltaTime);
        if (SonarScale.localScale.x >= 9)
        {
            Destroy(this.gameObject);
        }

    }
}
