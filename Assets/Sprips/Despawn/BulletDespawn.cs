using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : DespawnByDistance
{
    public override void Despawning�Obj()
    {
        BulletSpawner.Instance.Despawn(transform.parent);

    }
}
