using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SphereExpand : MonoBehaviour
{
    InputReader inputReader;
    int a = 0;
    [SerializeField] float speed = 1;
    [SerializeField] float scale = 1;
    void Start()
    {
        inputReader = Resources.Load<InputReader>("Input Reader Prefab");
        SetEevnts();
        transform.localScale=Vector3.one*scale;
    }
    void SetEevnts()
    {
        inputReader.SpacePressed += ChangeState;
    }
    void Update()
    {
        //一直按著空白鍵可以讓圓變大，沒有上限，但是圓的大小不會小於一個特定值
        if (transform.localScale.x >= scale || a >= 0)
        {
            transform.localScale += Vector3.one * a * speed * Time.deltaTime;
        }
    }
    void ChangeState(InputActionPhase phase)
    {
        if (phase == InputActionPhase.Performed)
        {
            a = 1;
        }
        else
        {
            a = -1;
        }
    }
}
