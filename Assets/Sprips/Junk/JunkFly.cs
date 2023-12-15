using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class JunkFly : ParenFly
{
    [SerializeField] protected float minCam = -5f;
    [SerializeField] protected float MaxCam = 5f;

    protected override void LoadValue()
    {
        base.LoadValue();
        moveSpeed = 0.5f;
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        GetFlyDirection();
    }

    protected virtual void GetFlyDirection()
    {
        Vector3 camPos = GameCtrl.Instance.MainCamera.transform.position;
        camPos.x += Random.Range(minCam, MaxCam);
        camPos.y += Random.Range(minCam, MaxCam);
        Vector3 objPos = transform.parent.position;
        Vector3 direction = camPos - objPos;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0,0,angle);

        Debug.DrawLine(camPos,objPos , Color.blue,Mathf.Infinity);
      
    }
}
