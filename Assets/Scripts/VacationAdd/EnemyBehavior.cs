using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    float Timer, FlashTime, Speed = 0.5f;//用來做閃紅光，預計之後砍掉，用shader或其他方式做
    [SerializeField]
    Animator animator;
    [SerializeField]
    List<Material> materials = new List<Material>();
    Transform player;
    GameObject Mesh;
    SkinnedMeshRenderer skinnedMeshRenderer;

    Rigidbody rb;
    void Start()
    {
        LoadMonserMaterial();
        player = GameObject.Find("XR Origin").transform;
        rb = GetComponent<Rigidbody>();
    }
    void LoadMonserMaterial()
    {
        Mesh = transform.Find("Monster/Cube").gameObject;
        skinnedMeshRenderer = Mesh.GetComponent<SkinnedMeshRenderer>();
        skinnedMeshRenderer.sharedMaterial = materials[0];
    }
    void OnTriggerStay(Collider collider)
    {
        MonsterMove();
        ChangeMaterial();
        if (animator.GetBool("Chasing") != true)
        {
            animator.SetBool("Chasing", true);
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (animator.GetBool("Chasing") != false)
        {
            animator.SetBool("Chasing", false);
        }
    }
    void FixedUpdate()
    {
        skinnedMeshRenderer.sharedMaterial = materials[0];
    }

    void ChangeMaterial()
    {
        skinnedMeshRenderer.sharedMaterial = materials[1];
    }

    void MonsterMove()
    {
        Vector3 dir = player.localPosition - transform.localPosition;
        transform.localPosition += dir * Time.deltaTime * Speed;
        transform.rotation = Quaternion.LookRotation(-dir);
    }
}
