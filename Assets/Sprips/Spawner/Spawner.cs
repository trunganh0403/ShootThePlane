using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class Spawner : GameMonoBehaviour
{


    [SerializeField] protected List<Transform> prefabs;

    [SerializeField] protected List<Transform> poolObjs;

    [SerializeField] protected Transform hodler;

    [SerializeField] private int spawnCount;

    public int SpawnCount { get => spawnCount;  }

    protected override void LoadComponents()
    {
        LoadPrefab();
        LoadHodler();

    }

    //gán ð?n vào lis 
    protected virtual void LoadPrefab()
    {
        if (prefabs.Count >0) return;

        Transform prefabObj = transform.Find("Prefabs");
        foreach (Transform bullet in prefabObj)
        {
            prefabs.Add(bullet);
        }
        HidePrefab();

    }


    protected virtual void LoadHodler()
    {
        if (hodler != null) return;
        hodler = transform.Find("Horled");
    }

    //tat trang thái
    protected virtual void HidePrefab()
    {

        foreach (Transform bullet in prefabs)
        {
            bullet.gameObject.SetActive(false);
        }

    }
    // spawn ðan
    public virtual Transform Spawn(string prefabName, Vector3 spamwPos, Quaternion rotation)
    {
        Transform prefab = GetPrefabByName(prefabName);
        if (prefab == null)
        {
            Debug.LogWarning("bullet null");
            return null;
        }
       

        return Spawn(prefab,spamwPos,rotation);
    }
    public virtual Transform Spawn(Transform prefabN, Vector3 spamwPos, Quaternion rotation)
    {

        Transform newPrefab = GetObjFromPool(prefabN);
        newPrefab.SetLocalPositionAndRotation(spamwPos, rotation);
        newPrefab.parent = hodler;
        spawnCount++;

        return newPrefab;
    }

    public virtual Transform GetObjFromPool(Transform prefab)
    {
        foreach (Transform poolObj in poolObjs)
        {
            if (poolObj.name== prefab.name)
                poolObjs.Remove(poolObj);
            return poolObj;
        }
        Transform newPool = Instantiate(prefab);
        newPool.name = prefab.name;
        return newPool;
    }
    public virtual void Despawn(Transform obj)
    {
        poolObjs.Add(obj);
        obj.gameObject.SetActive(false);
        spawnCount--;
    }

    // ktra tên ðan
    public virtual Transform GetPrefabByName(string prefabName)
    {
        foreach (Transform prefab in prefabs)
        {
            if (prefab.name == prefabName) return prefab;
        }
        return null;
    }

    public virtual Transform RandomPrefab()
    {
        int rad = Random.Range(0, prefabs.Count);
        foreach (Transform poolObj in poolObjs)
        {
            if (poolObj.name== prefabs[rad].name)
                poolObjs.Remove(poolObj);
            return poolObj;
        }
      
        return prefabs[rad];
       
    }
}
