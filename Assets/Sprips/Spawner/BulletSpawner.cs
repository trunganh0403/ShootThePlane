using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{

    private static BulletSpawner instance;
    public static BulletSpawner Instance { get => instance; }

    public string BulletOne = "Bullet1";



    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("dang co 2 BulletSpawner");
        }
    }
}
