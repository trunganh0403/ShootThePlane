using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : GameMonoBehaviour
{

    [SerializeField] protected DamegeSender damegeSender;

    public DamegeSender DamegeSender { get => damegeSender; }

    [SerializeField] protected BulletDespawn bulletDespawn;

    public BulletDespawn BulletDespawn { get => bulletDespawn; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadDamegeSender();
        LoadBulletDespawn();
    }
    protected virtual void LoadDamegeSender()
    {
        if (damegeSender != null) return;
        damegeSender = transform.GetComponentInChildren<DamegeSender>();
    }
    protected virtual void LoadBulletDespawn()
    {
        if(bulletDespawn != null) return;
        bulletDespawn = transform.GetComponentInChildren<BulletDespawn>();
    }
        
}
