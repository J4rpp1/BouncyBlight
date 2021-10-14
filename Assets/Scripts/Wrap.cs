using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour
{
    Vector3 newPosition;

    void Update()
    {
        if(transform.position.x < -12.5f)
		{
            newPosition.x = 12.5f;
            WrapPosition();
        }
        if (transform.position.x > 12.5f)
        {
            newPosition.x = -12.5f;
            WrapPosition();
        }

    }
    void WrapPosition()
    {
        newPosition = new Vector3(newPosition.x, transform.position.y, 0f);
        transform.position = newPosition;
    }
}
