using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDespawn : DespawnByDistance
{
   
    protected override void LoadComponents()
    {
        base.LoadComponents();
        //LoadJunkCtrl();
    }
    
    protected override void LoadValue()
    {
        base.LoadValue();
        distanceLimit = 20f;


    }

    public override void DespawningòObj()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
        Debug.Log("depawn");

    }
    
  
    
}
