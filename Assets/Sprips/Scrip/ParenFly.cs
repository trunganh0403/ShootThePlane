using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParenFly : GameMonoBehaviour
{
    [SerializeField] protected float moveSpeed = 1f;
    [SerializeField] protected Vector3 direction = Vector3.right;

    private void Update()
    {
        Fly();
    }
    protected virtual void Fly()
    {
        transform.parent.Translate(direction*moveSpeed*Time.deltaTime);
    }
}
