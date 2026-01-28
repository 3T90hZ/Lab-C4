using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    Vector3 moveDir;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        moveDir = new Vector3(h, 0, v);

        if (moveDir.magnitude > 1)
            moveDir.Normalize();

        transform.Translate(moveDir * speed * Time.deltaTime, Space.World);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(
            transform.position,
            transform.position + moveDir * 2f
        );
    }
}
