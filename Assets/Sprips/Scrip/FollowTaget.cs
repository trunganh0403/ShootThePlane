using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTaget : GameMonoBehaviour
{
    [SerializeField] GameObject taget;
    [SerializeField] float speed = 1f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadTaget();
    }
    private void FixedUpdate()
    {
        Following();
    }
    protected virtual void LoadTaget()
    {
        if (taget != null) return;
        taget = GameObject.Find("Ship");
    }
    protected virtual void Following()
    {
       transform.position = new Vector3(transform.position.x, transform.position.y, 1f);
       transform.position = Vector3.Lerp(transform.position,taget.transform.position,speed* Time.fixedDeltaTime);
    }
}
