using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class SpawnPoin : GameMonoBehaviour
{
    [SerializeField] protected List<Transform> spawnPoins;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSpawnPoin();
    }

    protected virtual void LoadSpawnPoin()
    {
        if (spawnPoins.Count > 0) return;
        foreach (Transform poin in transform)
        {

            spawnPoins.Add(poin);
            
        }
    }
    public virtual Transform GetRanDom()
    {
        int rad = Random.Range (0, spawnPoins.Count);
        return spawnPoins[rad];
    }    
}
