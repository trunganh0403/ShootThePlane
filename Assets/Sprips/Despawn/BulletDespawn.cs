using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : DespawnByDistance
{
    public override void DespawningòObj()
    {
        BulletSpawner.Instance.Despawn(transform.parent);

    }
}
