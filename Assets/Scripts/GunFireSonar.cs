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
    
    [SerializeField]GameObject BulletPrefab;
    void Start()
    {
        var inputReader=Resources.Load<InputReader>("Input Reader Prefab");
        inputReader.GunFireSonar+=SpawnBullet;
    }
    void SpawnBullet()
    {
        // GameObject.Instantiate()
    }
}
