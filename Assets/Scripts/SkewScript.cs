using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkewScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float squash, stretch, squashStretchMultiplier;
    [SerializeField] float smoothTime;
    SpriteRenderer slimeSprite;
    Vector3 squashAndStretch;
    Vector3 lastPosition;
    Vector3 velocityDirection;
    Vector3 smoothedDirection;
    Vector3 smoothVelocity = Vector3.zero;
    public bool freezeDeformation;
    void Start()
    {
        rb = transform.parent.gameObject.GetComponent<Rigidbody2D>();
        lastPosition = transform.position;
        slimeSprite = GetComponentInChildren<SpriteRenderer>();
        squashAndStretch = new Vector3(squash, 1f, stretch);
    }

	void FixedUpdate()
	{
        velocityDirection = (transform.position - lastPosition);
        lastPosition = transform.position;
    }
	void Update()
    {
        if (!freezeDeformation)
        {
            //velocityDirection is abrupt, so smooth it 
            smoothedDirection = Vector3.SmoothDamp(smoothedDirection, velocityDirection, ref smoothVelocity, smoothTime);

            //set rotation to smoothedDirection, plus a very tiny vector so we don't try to orient to zero vector
            transform.rotation = Quaternion.LookRotation(smoothedDirection + Vector3.forward*0.01f, Vector3.forward);

            //set scale based on direction vector magnitude between (1,1,1) and (squash, 1, stretch)
            transform.localScale = Vector3.Lerp(Vector3.one, squashAndStretch, smoothedDirection.magnitude * squashStretchMultiplier);

            //Freeze child sprite rotation by setting its rotation to parent rotation negated
            slimeSprite.transform.rotation = Quaternion.Euler(transform.rotation.x * -1f, transform.rotation.y * -1f, transform.rotation.z * -1f);
        }
    }
}
