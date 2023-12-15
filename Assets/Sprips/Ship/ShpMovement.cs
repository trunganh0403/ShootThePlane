using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpMovement : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float rotationSpeed;
    [SerializeField] protected Vector3 tagetPos;


    private void FixedUpdate()
    {
        GetTagetPos();
        LookAtTaget();
        Moving();

    }
    // lấy vtri taget
    protected virtual void GetTagetPos()
    {
        tagetPos = InputManager.Instance.MousPos;
        tagetPos.z =0;
    }
    // xoay theo taget
    protected virtual void LookAtTaget()
    {
        Vector3 direction = tagetPos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.parent.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
    // di chuyển theo taget
    protected virtual void Moving()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, tagetPos, speed);
        transform.parent.position = newPos;
    }
}
