using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDameReceiver : DamegeReceiver
{
    [SerializeField] protected JunkCtrl junkCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkCtrl();
        LoadReborn();
    }

    protected void LoadJunkCtrl()
    {
        if (junkCtrl != null) return;
        junkCtrl = transform.parent.GetComponent<JunkCtrl>();
    }
    protected void LoadReborn()
    {
        Reborn();
    }    

    public override void Reborn()
    {
        maxHp = junkCtrl.JunkSO.maxHp;
        base.Reborn();
    }
    public override void DestroyJunk()
    {
        base.DestroyJunk();
        Reborn();
        junkCtrl.JunkDespawn.DespawningòObj();
       
    }


}
