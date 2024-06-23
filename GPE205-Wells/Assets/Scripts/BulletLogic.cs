using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    // Variable for bullet speed
    public float bulletSpeed;

    // Getting Rigidbody component
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        rb.velocity += transform.forward * bulletSpeed * Time.deltaTime;
    }
}
