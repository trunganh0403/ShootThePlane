using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JunkAbstract : GameMonoBehaviour
{

    [SerializeField] protected JunkCtrl junkCtrl;

    public JunkCtrl JunkCtrls { get => junkCtrl; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadModel();

    }

    protected virtual void LoadModel()
    {
        if (junkCtrl != null) return;
        junkCtrl = transform.parent.GetComponent<JunkCtrl>();
    }
}
