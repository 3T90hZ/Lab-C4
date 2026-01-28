using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignedAngleRotate : MonoBehaviour
{
    public Transform target;
    public float angle;

    void Update()
    {
        Vector2 forward = transform.up;
        Vector2 toTarget = (target.position - transform.position).normalized;

        angle = Vector2.SignedAngle(forward, toTarget);
        transform.Rotate(0, 0, angle * Time.deltaTime);
    }
}

