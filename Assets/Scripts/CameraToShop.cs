using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToShop : MonoBehaviour
   {
    [SerializeField] Transform Position1;
    [SerializeField] Transform Position2;
    public Transform currentlyFollowing;
    public float speed = 0f;
    
    void Start()
    {
        transform.position = Position1.position;
    }

    // Update is called once per frame
    public void Shop()
    {
        transform.position = Position2.position;
     
    }

    public void Back()
    {
        transform.position = Position1.position;

    }

}
