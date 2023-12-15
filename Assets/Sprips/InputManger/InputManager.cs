using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }
   
    private Vector3 mousPos;
    public Vector3 MousPos { get => mousPos; }
  
    private float onFiring;
    public float OnFiring { get => onFiring; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("co 2 InputManager");
        }
    }
    private void FixedUpdate()
    {
        GetMousDown();
        GetMousPos();
    }
    //lấy phím nhấn chuột
    protected virtual void GetMousDown()
    {
        onFiring = Input.GetAxis("Fire1");
    }
    //lấy tọa độ chuột
    protected virtual void GetMousPos()
    {
        mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
       
}
