using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMethod : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform stickBone;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = this.transform.childCount+1;
    }

    // Update is called once per frame
    void Update()
    {
        stickBone = GameObject.Find("LinePivot").GetComponent<Transform>();
        lineRenderer.SetPosition(0, this.transform.position+new Vector3(0,0.1f,0));
        lineRenderer.SetPosition(6, stickBone.position);
        Transform[] forPoints = GetComponentsInChildren<Transform>();
        
        for(int i = 0 ; i<this.transform.childCount;i++)
        {
            lineRenderer.SetPosition(i,forPoints[i].position);
        }

     
    }
}
