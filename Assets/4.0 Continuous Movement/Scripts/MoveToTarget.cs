using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Vector3 targetPos;
    public bool move = false;
    float speed = 0.4f;

    public void MoveTo(Vector3 newTarget)
    {
        targetPos = newTarget;
        move = true;
    }


    void Update()
    {
        if (move)
        {
            Vector3 vectorToTarget = targetPos - transform.position;

            if (vectorToTarget.magnitude > 0.01f)
            {
                transform.position += vectorToTarget.normalized * speed * Time.deltaTime;
            }
            else
            {
                transform.position = targetPos;
                move = false;
            }
        }
    }
}
