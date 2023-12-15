using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletAbstract : GameMonoBehaviour
{
    [SerializeField] private BulletCtrl bulletCtrl;

    public BulletCtrl BulletCtrl { get => bulletCtrl; }

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
        
}
