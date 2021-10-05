using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.y > target.transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y, -10);
        }
    }
}
