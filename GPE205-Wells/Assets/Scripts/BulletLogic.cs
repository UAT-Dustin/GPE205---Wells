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

    // rb.velocity is an absolute velocity. Since we are simulating physics I am using the FixedUpdate()
    // this should not be multiplied by Time.deltaTime
    void FixedUpdate()
    {
        // Makes the bullet travel
        rb.velocity = transform.forward * bulletSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
