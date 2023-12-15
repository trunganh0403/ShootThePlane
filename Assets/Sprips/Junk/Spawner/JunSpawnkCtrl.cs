using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunSpawnkCtrl : GameMonoBehaviour
{
    [SerializeField] public JunkSpawner junkSpawner;
    [SerializeField] public JunkSpawnPoin junkSpawnPoin;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkSpawner();
        LoadJunkSpawnPoin();
    }

    protected virtual void LoadJunkSpawner()
    {
        if (junkSpawner != null) return;
        junkSpawner = GameObject.FindAnyObjectByType<JunkSpawner>();
    }
    protected virtual void LoadJunkSpawnPoin()
    {
        if (junkSpawnPoin != null) return;
        junkSpawnPoin = GameObject.FindAnyObjectByType<JunkSpawnPoin>();
    }

}
