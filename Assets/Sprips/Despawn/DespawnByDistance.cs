using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected Camera mainCam;

    [SerializeField] protected float distance;

    [SerializeField] protected float distanceLimit = 70f;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (mainCam != null) return;
        mainCam = Transform.FindObjectOfType<Camera>();
    }

    //override lại ktra có thể despawn
    protected override bool CanDespawn()
    {
        distance = Vector3.Distance(transform.position, mainCam.transform.position);
        if (distance < distanceLimit) return false;
        return true;
    }
}
