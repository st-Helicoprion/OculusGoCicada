using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Bulletbullbletrail : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeSpawn;
    public float StartTimeSpawn;
    public GameObject echo;
    public float ExistTime = 1;
    public float MaxDistance = 10 ;
    [SerializeField]float Speed=1;
    public GameObject mainCamera;
    public float Spawntimeinterval;
    // Update is called once per frame
    Vector3 direction;
    void Start()
    {
        mainCamera= GameObject.Find("Main Camera");
    }
    void Update()
    {
        direction=mainCamera.transform.forward;
        transform.position+=direction*Time.deltaTime*Speed;
        MaxDistance-=Time.deltaTime*Speed;
        if(MaxDistance<0)
        {
            Destroy(this.gameObject);
        }
            if (timeSpawn <= 0)
            {
                GameObject intance = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
                Destroy(intance, ExistTime);
                timeSpawn = StartTimeSpawn;
            }
            else
            {
                timeSpawn -= Time.deltaTime;
            }
        

    }
}
