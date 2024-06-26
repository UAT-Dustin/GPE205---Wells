using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    [Header("Player Movement")]
    // Variable for move speed
    public float moveSpeed;
    // Variable for turn speed
    public float turnSpeed;
    // Variable to hold our Mover
    public Mover mover;

    [Header("Shooting Logic")]
    public Shooter shooter;
    public GameObject shellPrefab;
    public float fireForce;
    public float damageDone;
    public float shellLifespan;

    public float fireRate;
    public float fireCounter;
    public bool canFire = true;

    // Firepoint Transform
    public Transform firePoint;
    public GameObject bullet;

    // Called at start
    public virtual void Start()
    {
        mover = GetComponent<Mover>();
        shooter = GetComponent<Shooter>();
    }

    // Called per update
    public virtual void Update()
    {

    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
    public abstract void Shoot();
}
