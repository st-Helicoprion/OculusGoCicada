using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFireSonar : MonoBehaviour
{
    [SerializeField] GameObject BulletPrefab;
    [SerializeField] Transform BulletTrashCan;
    [SerializeField] Transform BulletSpawnPoint;
    [SerializeField] float ExistTime=5;
    GameObject bulletTemp;
    void Start()
    {
        var inputReader = Resources.Load<InputReader>("Input Reader Prefab");
        inputReader.GunFireSonar += SpawnBullet;
    }
    void SpawnBullet()
    {
        bulletTemp=GameObject.Instantiate(BulletPrefab,BulletSpawnPoint);
        bulletTemp.transform.SetParent(BulletTrashCan);//Leave Bullets at current palce
        Debug.Log("spawn");
        Destroy(bulletTemp,ExistTime);
        // GameObject.Instantiate()
    }

}
