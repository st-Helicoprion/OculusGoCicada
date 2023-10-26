using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFireSonar : MonoBehaviour
{
    [SerializeField] GameObject BulletPrefab;
    [SerializeField] Transform BulletSpawnPoint;
    [SerializeField] float ExistTime = 1;
    [SerializeField] float SpawnSonar = 10;
    [SerializeField] float TimeInterval = 0.5f;
    GameObject bulletTemp;
    InputReader inputReader;
    void Start()
    {
        inputReader = Resources.Load<InputReader>("Input Reader Prefab");
        inputReader.GunFireSonar += SpawnBullet;
    }
    void SpawnBullet()
    {
        Vector3 CurrentSpawnLocation;
        Quaternion CurrentSpawnRotation;
        CurrentSpawnLocation = BulletSpawnPoint.position;//存取現在的位置和旋轉角度
        CurrentSpawnRotation= BulletSpawnPoint.rotation;
        StartCoroutine(SpawnBulletRepeat(CurrentSpawnLocation,CurrentSpawnRotation));
    }

    IEnumerator SpawnBulletRepeat(Vector3 vector3,Quaternion quaternion)
    {
        //SpawnBullet觸發後，每經過TimeInterval的時間，生成一個聲波，總共生SpawnSonar個
        for (int i = 0; i < SpawnSonar; i++)
        {
            bulletTemp = GameObject.Instantiate(BulletPrefab, vector3,quaternion);
            Debug.Log("spawn");
            Destroy(bulletTemp, ExistTime);
            yield return new WaitForSecondsRealtime(TimeInterval);
        }
    }

}
