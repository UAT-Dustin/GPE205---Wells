using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{
    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
        ShootingTimerLogic();
    }

    public override void MoveForward()
    {
        Debug.Log("Move Forward");
        mover.Move(transform.forward, moveSpeed);
    }

    public override void MoveBackward()
    {
        Debug.Log("Move Backward");
        mover.Move(transform.forward, -moveSpeed);
    }

    public override void RotateClockwise()
    {
        Debug.Log("Move Clockwise");
        mover.Rotate(turnSpeed);
    }

    public override void RotateCounterClockwise()
    {
        Debug.Log("Move Counter-Clockwise");
        mover.Rotate(-turnSpeed);
    }

    public override void Shooting()
    {
        if (canFire)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            fireCounter = 0;
            canFire = false;
        }
    }

    private void ShootingTimerLogic()
    {
        fireCounter += Time.deltaTime;

        if (fireCounter > fireRate)
        {
            canFire = true;
        }
    }
}
