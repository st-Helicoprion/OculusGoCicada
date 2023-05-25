using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarSkill : MonoBehaviour
{
    public GameObject prefab;
    public Transform playerPos, stickPos;
    public float frequency;

    [Header("Circle Checker")]
    public Vector3 curPos;
    public Vector3 refPos;
    public float threshold, limit, freqTime, count;
    public bool isCircle = false;

    public List<int> hitOrder = new List<int>();
   

    // Start is called before the first frame update
    void Start()
    { 
        playerPos = GameObject.Find("XR Origin").GetComponent<Transform>();
        refPos = transform.position;
        curPos = GameObject.Find("CicadaTub").GetComponent<Transform>().position;
        stickPos = GameObject.Find("ObiLinePivot").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (frequency <= 0)
        {
            frequency = 0;
        }
        else frequency -= 0.5f*Time.deltaTime;

        count+=Time.deltaTime;

       if(hitOrder.Count>4)
        {
            hitOrder.Clear();
        }

         for(int i = 0; i<hitOrder.Count; i++)
        {
            Debug.Log(hitOrder[i]);
            if(Mathf.Abs(hitOrder[i]-hitOrder[i+1])==1&&hitOrder[0]==hitOrder[3])
            {
                SummonSonar();
                hitOrder.Clear();
            }
            if(hitOrder[3]==1||hitOrder[3]==3)
            Debug.Log(hitOrder[0]+"->"+hitOrder[1]+"->"+hitOrder[2]+"->"+hitOrder[3]);
        }

    }

    public void SummonSonar()
    {
         Instantiate(prefab, playerPos.position+new Vector3(0,-5,0),Quaternion.identity);
    }


    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.CompareTag("Buzz"))
    //     {
    //        SummonSonar();
    //         frequency++;
    //     }
    // }
}
