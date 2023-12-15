using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletImpart : BulletAbstract
{// ktra va cham collider

    [SerializeField] Rigidbody rb;
    [SerializeField] SphereCollider sphere;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadRigibody();
        LoadCollider();
    }
    protected virtual void LoadRigibody()
    {
        if (rb != null) return;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;

    }

    protected virtual void LoadCollider()
    {
       if(sphere != null) return;
       sphere = GetComponent<SphereCollider>();
        sphere.isTrigger = true;
        sphere.radius = 0.167329f;
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("va cham");
        BulletCtrl.DamegeSender.Send(collision.transform);

    }
}
