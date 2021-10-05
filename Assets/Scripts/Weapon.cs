using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject firePrefab;

   
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            shoot();
        }
    }

    void shoot ()
    {
        Instantiate(firePrefab, firePoint.position, firePoint.rotation);
    }
}
