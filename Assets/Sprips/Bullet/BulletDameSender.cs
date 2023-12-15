using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDameSender : DamegeSender
{
    [SerializeField] BulletCtrl bulletCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadBulletCtrl();
    }

    protected virtual void LoadBulletCtrl()
    {
        if (bulletCtrl != null) return;
        bulletCtrl = transform.parent.GetComponent<BulletCtrl>();
    }
    public override void Send(DamegeReceiver damegeReceiver)
    {
        base.Send(damegeReceiver);
        DestroyBullet();
    }
    public virtual void DestroyBullet()
    {
        bulletCtrl.BulletDespawn.DespawningòObj();
    }    

}
