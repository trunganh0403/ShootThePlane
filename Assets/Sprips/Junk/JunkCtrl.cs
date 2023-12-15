using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : GameMonoBehaviour
{
    [SerializeField] private JunkDespawn junkDespawn;
    public JunkDespawn JunkDespawn { get => junkDespawn;  }

    [SerializeField] protected Transform model;

    public Transform Model { get => model; }

    public JunkSO JunkSO { get => junkSO;  }
    

    [SerializeField] private JunkSO junkSO;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadModel();
        LoadJunkSO();
        LoadDameReceiver();

    }
    protected virtual void LoadDameReceiver()
    {
        if (junkDespawn != null) return;
        junkDespawn = transform.GetComponentInChildren<JunkDespawn>();
    }
    protected virtual void LoadModel()
    {
        if (model != null) return;
        model = transform.Find("Model");
    }

    protected virtual void LoadJunkSO()
    {
        if (junkSO != null) return;
        string resPath = "Junk/" + transform.name;
        junkSO = Resources.Load<JunkSO>(resPath);
    }

}
