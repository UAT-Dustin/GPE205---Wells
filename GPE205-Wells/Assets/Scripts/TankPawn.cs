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
        mover.Move(transform.forward, moveSpeed);
    }

    public override void MoveBackward()
    {
        mover.Move(transform.forward, -moveSpeed);
    }

    public override void RotateClockwise()
    {
        mover.Rotate(turnSpeed);
    }

    public override void RotateCounterClockwise()
    {
        mover.Rotate(-turnSpeed);
    }

    // Instantiations bullet when the shooting function is called
    public override void Shoot()
    {
        if(canFire)
        {
            shooter.Shoot(shellPrefab, fireForce, damageDone, shellLifespan);
            fireCounter = 0;
            canFire = false;
        }
    }

    // Logic that controls the shooting cooldown for the player using a boolean
    private void ShootingTimerLogic()
    {
        fireCounter += Time.deltaTime;

        if (fireCounter > fireRate)
        {
            canFire = true;
        }
    }
}
