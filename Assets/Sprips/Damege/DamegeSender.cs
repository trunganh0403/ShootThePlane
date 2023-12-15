using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class DamegeSender : GameMonoBehaviour
{
    [SerializeField] protected int dame = 1;

    public virtual void Send(Transform obj)
    {
        DamegeReceiver damegeReceiver = obj.GetComponentInChildren<DamegeReceiver>();
        if (damegeReceiver == null) return;
        Send(damegeReceiver);

    }
    public virtual void Send(DamegeReceiver damegeReceiver)
    {
        damegeReceiver.Deduct(dame);
        //DestroyObj();

    }
    protected virtual void DestroyObj()
    {
        Destroy(transform.parent.gameObject);

    }




}
