using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junkrotation : JunkAbstract
{
    [SerializeField] protected float rotationSpeed =40f;

    private void FixedUpdate()
    {
        Rotateing();
    }
    protected virtual void Rotateing()
    {
        JunkCtrls.Model.Rotate(new Vector3(0, 0, 1) * rotationSpeed * Time.fixedDeltaTime);
    }
        
}
