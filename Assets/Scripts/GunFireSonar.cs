using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFireSonar : MonoBehaviour
{
    /*
        condition confirm(if triiger pulled)use f key instead
        spawn a sonar
        moving that stuff
        let it last for a while and then delete it
        visual improve
    */

    [SerializeField] GameObject BulletPrefab;
    [SerializeField] Animator animator;
    void Start()
    {
        var inputReader = Resources.Load<InputReader>("Input Reader Prefab");
        inputReader.GunFireSonar += SpawnBullet;
    }
    //bullet extend not spawn for now (10/23)
    void SpawnBullet()
    {
        // GameObject.Instantiate()
    }

}
