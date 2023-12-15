using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{

    private static JunkSpawner instance;
    public static JunkSpawner Instance { get => instance; }

    public string meteoriOne = "Meteorite_1";



    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("dang co 2 JunkSpawner");
        }
    }

   
}
