using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeReceiver : GameMonoBehaviour
{
    [SerializeField] protected int hp=1;
    [SerializeField] protected int maxHp = 3;
    [SerializeField] protected bool isDead;

    protected override void Start()
    {
        base.Start();
        Reborn();
    }
    protected void Update()
    {
        IsDestroy();
        IsDead();

    }
    public virtual void Reborn()
    {
        hp = maxHp;
        isDead = false;
    }

    protected virtual void Add(int add)
    {
        hp += add;
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }

    public virtual void Deduct(int add)
    {
        hp -= add;
        if (hp <=0)
        {
            hp = 0;
        }
    }

    public virtual void IsDead()
    {
        if (hp <=0)
        {
            isDead = true;
        }
        else
        {
            isDead = false;
        }
    }
    public virtual void IsDestroy()
    {
        if (isDead == false) return;
       
        DestroyJunk();



    }
    public virtual void DestroyJunk()
    {
       

    }
    
}
