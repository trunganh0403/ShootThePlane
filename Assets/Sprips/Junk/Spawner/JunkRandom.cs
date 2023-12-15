using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : GameMonoBehaviour
{
    [SerializeField] JunSpawnkCtrl junkSpawnCtrl;
    [SerializeField] protected float randomDelay = 2f;
    [SerializeField] protected float randomTimer;
    [SerializeField] protected int randomLimit = 45;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkSpawner();

    }
    protected virtual void  LoadJunkSpawner()
    {
        if (junkSpawnCtrl != null) return;
        junkSpawnCtrl = GameObject.FindAnyObjectByType<JunSpawnkCtrl>();
    }
    private void FixedUpdate()
    {
        JunkSpawning();
    }
    protected virtual void JunkSpawning()
    {
        if (RandomReachLimit()) return;
        randomTimer += Time.fixedDeltaTime;
        if (randomTimer < randomDelay) return;
        randomTimer = 0f;

        Transform ranDom = junkSpawnCtrl.junkSpawnPoin.GetRanDom();
        Vector3 spawnPos = ranDom.position;
        spawnPos.z = 0;
        Quaternion rotion = transform.rotation;
        Transform prefab = junkSpawnCtrl.junkSpawner.RandomPrefab();
        Transform obj = junkSpawnCtrl.junkSpawner.Spawn(prefab, spawnPos, rotion);
        obj .gameObject.SetActive(true);
       
       
    }    

    protected virtual bool RandomReachLimit()
    {
        int currentJunk = junkSpawnCtrl.junkSpawner.SpawnCount;
        return currentJunk >= randomLimit;
    }

}
