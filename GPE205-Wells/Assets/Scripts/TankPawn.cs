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
    }

    public override void MoveForward()
    {
        Debug.Log("Move Forward");
    }

    public override void MoveBackward()
    {
        Debug.Log("Move Backward");
    }

    public override void RotateClockwise()
    {
        Debug.Log("Move Clockwise");
    }

    public override void RotateCounterClockwise()
    {
        Debug.Log("Move Counter-Clockwise");
    }

}
