using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class RepeatingSonar : MonoBehaviour
{
    public Transform playerPos;
    public GameObject limitSonar, prefabSonar, particle;
    public float count, releaseTime = 1;

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if(count > releaseTime) { ReleaseSonarWave(); }

        limitSonar.transform.position = playerPos.position;
    }

    public void ReleaseSonarWave()
    {
        count = 0;

        if (limitSonar.transform.localScale.x > 5)
        {
            particle.SetActive(true);
            Instantiate(prefabSonar, limitSonar.transform.position, Quaternion.identity);
        }
        else particle.SetActive(false);
    }

    
}
