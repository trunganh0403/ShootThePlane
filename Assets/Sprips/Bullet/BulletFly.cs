using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : ParenFly
{
    protected override void LoadValue()
    {
        base.LoadValue();
        moveSpeed = 10f;
    }
}
