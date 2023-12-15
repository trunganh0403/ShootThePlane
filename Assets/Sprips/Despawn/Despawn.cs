using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : GameMonoBehaviour
{
    private void FixedUpdate()
    {
        Despawning�();
        CanDespawn();
        DespawnDameRecever();
    }
    protected virtual void Despawning�()
    {
        if (!CanDespawn() == true) return;
        Despawning�Obj();
    }
    public virtual void Despawning�Obj()
    {
        //Destroy(transform.parent.gameObject);

    }
    protected abstract bool CanDespawn();

    protected virtual void DespawnDameRecever()
    {
        
    }

}
