using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    // Variable to hold our Pawn
    public Pawn pawn;

    public virtual void Start() { }

    public virtual void Update() { }

    // Our child classes MUST override the way they process inputs
    public abstract void ProcessInputs();
}
