using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting;


    [SerializeField] protected float shootTimer;
    [SerializeField] protected float shootDelay = 0.2f;


    private void Update()
    {
       
        IsShooting();
    }
    private void FixedUpdate()
    {
        Shooting();
    }

    //b?n ð?n
    protected virtual void Shooting()
    {
        if (isShooting==false) return;

        shootTimer += Time.fixedDeltaTime;
        if (shootTimer<shootDelay) return;
        shootTimer = 0f;
      
        Vector3 spamwPos = transform.parent.position;
        //spamwPos.y +=1;
        Quaternion rotation =  transform.rotation;

       
        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.Instance.BulletOne, spamwPos , rotation);
        if (newBullet == null) return;
        newBullet.gameObject.SetActive(true);
    }
    //ktra có b?n ko
    protected virtual bool IsShooting()
    {
        isShooting = InputManager.Instance.OnFiring==1;
        return isShooting;
    }

}
