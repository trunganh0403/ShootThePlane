using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : GameMonoBehaviour
{
    private void FixedUpdate()
    {
        Despawningò();
        CanDespawn();
        DespawnDameRecever();
    }
    protected virtual void Despawningò()
    {
        if (!CanDespawn() == true) return;
        DespawningòObj();
    }
    public virtual void DespawningòObj()
    {
        //Destroy(transform.parent.gameObject);

    }
    protected abstract bool CanDespawn();

    protected virtual void DespawnDameRecever()
    {
        
    }

}
