using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : GameMonoBehaviour
{
    private static GameCtrl instance;
    public static GameCtrl Instance { get => instance;  }

    [SerializeField] private Camera mainCamera;
    public Camera MainCamera { get => mainCamera; }


    protected override void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("co 2 GameCtrl");
        }
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (mainCamera != null) return;
        mainCamera= GameObject.FindAnyObjectByType<Camera>();
    }
}
