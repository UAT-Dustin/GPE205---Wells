using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    // Variable for move speed
    public float moveSpeed;
    // Variable for turn speed
    public float turnSpeed;
    // Variable to hold our Mover
    public Mover mover;
    // Variable for Rate of Fire
    public float fireRate;
    [HideInInspector] public float fireCounter;
    [HideInInspector] public bool canFire = true;

    // Firepoint Transform
    public Transform firePoint;
    public GameObject bullet;

    // Called at start
    public virtual void Start()
    {
        mover = GetComponent<Mover>();
    }

    // Called per update
    public virtual void Update()
    {

    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
    public abstract void Shooting();
}
